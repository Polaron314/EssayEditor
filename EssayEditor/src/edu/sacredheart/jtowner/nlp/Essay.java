package edu.sacredheart.jtowner.nlp;

import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;

public class Essay {
	
	String rawText;
	String[] sentences;
	String[][] tokens;
	String[][] tags;
	
	public Essay(String path) {
		try {
			rawText = this.readFile(path, Charset.defaultCharset());
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public void process() {
		LanguageProcessor lp = new LanguageProcessor();
		this.sentences = lp.toSentences(rawText);
		tokens = new String[sentences.length][];
		tags = new String[sentences.length][];
		for(int i = 0; i < sentences.length; i++) {
			tokens[i] = lp.tokenizer(sentences[i]);
			tags[i] = lp.POSTagger(tokens[i]);
		}
	}

	private String readFile(String path, Charset encoding) 
			throws IOException 
	{
		byte[] encoded = Files.readAllBytes(Paths.get(path));
		return new String(encoded, encoding);
	}

}
