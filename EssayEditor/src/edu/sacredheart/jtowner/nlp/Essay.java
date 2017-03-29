package edu.sacredheart.jtowner.nlp;

import java.io.IOException;
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
	HashMap<String, List<Location>> pronounUsage;
	HashMap<String, List<Location>> punctuationUsage;
	LinkedHashMap<String, Integer> wordFrequency;
	List<Verb> verbs;
	
	public Essay(String path) {
		try {
			rawText = this.readFile(path, Charset.defaultCharset());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public void process() {
		System.out.println("Initializing");
		LanguageProcessor lp = new LanguageProcessor();
		MetricProcessor mp = new MetricProcessor();
		System.out.println("Processing Sentneces...");
		this.sentences = lp.toSentences(rawText);
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
		System.out.println("Processing Metrics...");
		wordCount = mp.getWordCount(rawText);
		sentenceLengths = mp.getSentenceLength(sentences);
		wordFrequency = mp.getWordFrequency(tokens);
		pronounUsage = mp.getPronounUsage(tokens);
		punctuationUsage = mp.getPunctuationUsage(tokens);
		VerbProcessor vp = new VerbProcessor();
		verbs = vp.process(tokens, tags);
		
		System.out.println("Done!");
		System.out.println();
		
		this.sentenceToText(0);
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
	}

	private String readFile(String path, Charset encoding) 
			throws IOException 
	{
		byte[] encoded = Files.readAllBytes(Paths.get(path));
		return new String(encoded, encoding);
	}
	
	public void sentenceToText(int s) {
		int length = spans[s][spans[s].length - 1].getEnd();
		StringBuilder sb = new StringBuilder(length);
		for(int i = 0; i < length; i++) {
			sb.insert(i, " ");
		}
		for(int i = 0; i < spans[s].length; i++) {
			sb.replace(spans[s][i].getStart(), spans[s][i].getEnd(), tokens[s][i]);
		}
		System.out.println(sb);
	}

}
