package edu.sacredheart.jtowner.nlp;

import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.List;

public class Essay {
	
	String rawText;
	String[] sentences;
	String[][] tokens;
	String[][] tags;
	int wordCount;
	int[] sentenceLengths;
	HashMap<String, List<Location>> pronounUsage;
	HashMap<String, List<Location>> punctuationUsage;
	LinkedHashMap<String, Integer> wordFrequency;
	
	public Essay(String path) {
		try {
			rawText = this.readFile(path, Charset.defaultCharset());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public void process() {
		LanguageProcessor lp = new LanguageProcessor();
		MetricProcessor mp = new MetricProcessor();
		System.out.println("Processing Sentneces...");
		this.sentences = lp.toSentences(rawText);
		System.out.println("Processing Tokens...");
		tokens = new String[sentences.length][];
		tags = new String[sentences.length][];
		for(int i = 0; i < sentences.length; i++) {
			System.out.println("Processing Sentence " + (i+1) + "/" + sentences.length);
			tokens[i] = lp.tokenizer(sentences[i]);
			tags[i] = lp.POSTagger(tokens[i]);
		}
		System.out.println("Processing Metrics...");
		wordCount = mp.getWordCount(rawText);
		sentenceLengths = mp.getSentenceLength(sentences);
		wordFrequency = mp.getWordFrequency(tokens);
		pronounUsage = mp.getPronounUsage(tokens);
		punctuationUsage = mp.getPunctuationUsage(tokens);
		System.out.println("Done!");
		
		VerbProcessor vp = new VerbProcessor();
		for(int i = 0; i < sentences.length; i++) {
			System.out.println(Arrays.toString(vp.process(tokens[i], tags[i])));
		}
	}

	private String readFile(String path, Charset encoding) 
			throws IOException 
	{
		byte[] encoded = Files.readAllBytes(Paths.get(path));
		return new String(encoded, encoding);
	}

}
