package edu.sacredheart.jtowner.nlp;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.util.List;

public class DocumentCreator {
	
	public DocumentCreator() {
		
	}
	
	public void processAll(Essay e) {
		this.writeToFile(this.processVerbs(e, e.getVerbs()), new File("verbs.txt"));
		this.writeToFile(this.processPronouns(e, e.getPronouns()), new File("pronoun.txt"));
		this.processEssayText(e);
	}
	
	public String[] processVerbs(Essay e, List<Verb> verbs) {
		String[] verbString = new String[verbs.size()];
		for(int i = 0; i < verbs.size(); i++) {
			String line = verbs.get(i).toString(e);
			verbString[i] = line.substring(1, line.length() - 1);
		}
		return verbString;
	}
	
	public String[] processPronouns(Essay e, List<Pronoun> pronouns) {
		String[] pronounString = new String[pronouns.size()];
		for(int i = 0; i < pronouns.size(); i++) {
			String line = pronouns.get(i).toString(e);
			pronounString[i] = line.substring(1, line.length() - 1);
		}
		return pronounString;
	}
	
	public void writeToFile(String[] lines, File file) {
		try {
			PrintWriter writer = new PrintWriter(file, "UTF-8");
			for(String l : lines) {
				writer.println(l);
			}
			writer.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (UnsupportedEncodingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void processEssayText(Essay e) {
		String[] output = new String[1];
		output[0] = "";
		String[] lengths = new String[e.getSentences().length];
		int currLength = 0;
		int i = 0;
		for(String sentence : e.getSentences()) {
			lengths[i] = currLength + "";
			i++;
			currLength += sentence.length() + 1;
			output[0] += sentence + " ";
		}
		this.writeToFile(output, new File("out.txt"));
		this.writeToFile(lengths, new File("marks.txt"));
	}
	
}
