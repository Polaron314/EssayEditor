package edu.sacredheart.jtowner.nlp;

import java.io.IOException;
import java.io.PrintStream;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.List;

import com.tutego.jrtf.Rtf;

import opennlp.tools.tokenize.DetokenizationDictionary;
import opennlp.tools.tokenize.DetokenizationDictionary.Operation;
import opennlp.tools.tokenize.DictionaryDetokenizer;
import opennlp.tools.util.Span;

public class Essay {
	
	String rawText;
	String[] sentences;
	String[][] tokens;
	String[][] tags;
	Span[][] spans;
	int wordCount;
	int[] sentenceLengths;
	HashMap<String, List<Location>> punctuationUsage;
	LinkedHashMap<String, Integer> wordFrequency;
	List<Verb> verbs;
	List<Pronoun> pronouns;
	LanguageProcessor lp;
	MetricProcessor mp;
	
	public Essay(String path, boolean isPath) {
		try {
			rawText = this.readFile(path, Charset.forName("UTF-8"));
		} catch(Exception e) {
			e.printStackTrace();
		}
		lp = new LanguageProcessor();
		mp = new MetricProcessor();
	}
	
	public Essay() {
		rawText = "";
		lp = new LanguageProcessor();
		mp = new MetricProcessor();
	}
	
	public Essay(String text) {
		rawText = text;
		lp = new LanguageProcessor();
		mp = new MetricProcessor();
	}
	
	public void update(String text) {
		this.rawText = text;
		//long startTime = System.nanoTime();
		String[] oldSentences = sentences;
		sentences = lp.toSentences(text);
		//long sentTime = System.nanoTime();
		//System.out.println("Completed in " + (sentTime - startTime)/1000000 + " ms");
		boolean isFirstTime = true;
		if(tokens != null) {
			isFirstTime = false;
		} 
		String[][] oldTokens = tokens;
		String[][] oldTags = tags;
		Span[][] oldSpans = spans;
		tokens = new String[sentences.length][];
		tags = new String[sentences.length][];
		spans = new Span[sentences.length][];
		boolean isOld = false;
		for(int i = 0; i < sentences.length; i++) {
			//long sentStartTime = System.nanoTime();
			isOld = false;
			if(!isFirstTime) {
				for(int j = 0; j < oldSentences.length; j++) {
					if(sentences[i].equals(oldSentences[j])) {
						//System.out.println("Using old ref " + j + " for new sent " + i);
						tokens[i] = oldTokens[j];
						tags[i] = oldTags[j];
						spans[i] = oldSpans[j];
						isOld = true;
					}
				}
			}
			if(!isOld) {
				tokens[i] = lp.tokenizer(sentences[i]);
				spans[i] = lp.getTokenSpans(sentences[i]);
				tags[i] = lp.POSTagger(tokens[i]);
			}
			//long sentEndTime = System.nanoTime();
			//System.out.println("Sentence " + i + " Duration " + (sentEndTime - sentStartTime)/1000000 + " ms");
		}
		//long tokenTime = System.nanoTime();
		//System.out.println("Completed in " + (tokenTime - sentTime)/1000000 + " ms");
		wordCount = mp.getWordCount(rawText);
		sentenceLengths = mp.getSentenceLength(sentences);
		wordFrequency = mp.getWordFrequency(tokens);
		pronouns = mp.getPronounUsage(tokens);
		punctuationUsage = mp.getPunctuationUsage(tokens);
		VerbProcessor vp = new VerbProcessor();
		verbs = vp.process(tokens, tags);
		//long metricTime = System.nanoTime();
		//System.out.println("Completed in " + (metricTime - tokenTime)/1000000 + " ms");
		//System.out.println("Done!");
		//System.out.println("Completed in " + (metricTime - startTime)/1000000 + " ms");
	}
	
	/*public void process() {
		long startTime = System.nanoTime();
		System.out.println("Initializing");
		System.out.println("Processing Sentences...");
		this.sentences = lp.toSentences(rawText);
		long sentTime = System.nanoTime();
		System.out.println("Completed in " + (sentTime - startTime)/1000000 + " ms");
		System.out.println("Processing Tokens...");
		tokens = new String[sentences.length][];
		tags = new String[sentences.length][];
		spans = new Span[sentences.length][];
		for(int i = 0; i < sentences.length; i++) {
			System.out.println("Processing Sentence " + (i+1) + "/" + sentences.length);
			tokens[i] = lp.tokenizer(sentences[i]);
			spans[i] = lp.getTokenSpans(sentences[i]);
			tags[i] = lp.POSTagger(tokens[i]);
		}
		long tokenTime = System.nanoTime();
		System.out.println("Completed in " + (tokenTime - sentTime)/1000000 + " ms");
		System.out.println("Processing Metrics...");
		wordCount = mp.getWordCount(rawText);
		sentenceLengths = mp.getSentenceLength(sentences);
		wordFrequency = mp.getWordFrequency(tokens);
		pronouns = mp.getPronounUsage(tokens);
		punctuationUsage = mp.getPunctuationUsage(tokens);
		VerbProcessor vp = new VerbProcessor();
		verbs = vp.process(tokens, tags);
		long metricTime = System.nanoTime();
		System.out.println("Completed in " + (metricTime - tokenTime)/1000000 + " ms");
		
		System.out.println("Done!");
		System.out.println("Completed in " + (metricTime - startTime)/1000000 + " ms");
		System.out.println();
		
		for(Verb v : verbs) {
			System.out.println(v.toString(this));
			System.out.println(this.getLocationText(v));
		}
		
		for(Pronoun p : pronouns) {
			System.out.println(p.toString(this));
			System.out.println(this.getLocationText(p));
		}
		
		DocumentCreator dc = new DocumentCreator();
		//dc.processAll(this);
		//this.sentenceToText(0);
		//this.print();
		//System.out.println(this.pronounUsage);
	}
	
	private String getLocationText(Location l) {
		int sen = l.getSentence();
		int st = l.getTokenStart();
		int len = l.getLength();
		String text = "";
		for(int i = st; i < st + len; i++) {
			text += tokens[sen][i] + " ";
		}
		return text.substring(0, text.length() - 1);
	}*/

	private String readFile(String path, Charset encoding) 
			throws IOException 
	{
		byte[] encoded = Files.readAllBytes(Paths.get(path));
		return new String(encoded, encoding);
	}
	
	public String sentenceToText(int s) {
		int length = spans[s][spans[s].length - 1].getEnd();
		StringBuilder sb = new StringBuilder(length);
		for(int i = 0; i < length; i++) {
			sb.insert(i, " ");
		}
		for(int i = 0; i < spans[s].length; i++) {
			sb.replace(spans[s][i].getStart(), spans[s][i].getEnd(), tokens[s][i]);
		}
		return sb.toString();
	}
	
	public Span getSpan(int sentence, int token) {
		return this.spans[sentence][token];
	}

	public List<Verb> getVerbs() {
		return verbs;
	}
	
	public Verb[] getVerbArray() {
		return verbs.toArray(new Verb[verbs.size()]);
	}
	
	public Pronoun[] getPronounArray() {
		return pronouns.toArray(new Pronoun[pronouns.size()]);
	}
	
	public List<Pronoun> getPronouns() {
		return pronouns;
	}
	
	public String[] getSentences() {
		return this.sentences;
	}
	
	public int[] getSentenceStarts() {
		return this.lp.sentenceStarts(this.rawText);
	}
	
	public String[] getCommonWords() {
		String[] out = new String[wordFrequency.size()];
		int i = 0;
		for(String key : this.wordFrequency.keySet()) {
			out[i] = key + ": " + this.wordFrequency.get(key);
			i++;
		}
		return out;
	}
	
	public int getWordCount() {
		return this.wordCount;
	}
	
	public int getCharCount() {
		return this.rawText.length();
	}
	
	public int getSentenceCount() {
		return this.sentences.length;
	}
	
	public int[] getSentenceLengths() {
		int[] lengths = new int[this.sentences.length];
		for(int i = 0; i < this.sentences.length; i++) {
			lengths[i] = mp.getWordCount(sentences[i]);
		}
		return lengths;
	}
}
