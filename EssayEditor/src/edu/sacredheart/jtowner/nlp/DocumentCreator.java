package edu.sacredheart.jtowner.nlp;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.List;

public class DocumentCreator {
	
	public DocumentCreator() {
		
	}
	
	public void processAll(Essay e) {
		this.writeToFile(this.processVerbs(e, e.getVerbs()), new File("verbs.txt"));
		this.writeToFile(this.processPronouns(e, e.getPronouns()), new File("pronouns.txt"));
	}
	
	public String[] processVerbs(Essay e, List<Verb> verbs) {
		String[] verbString = new String[verbs.size()];
		for(int i = 0; i < verbs.size(); i++) {
			String line = verbs.get(i).toString(e);
			verbString[i] = line.substring(1, line.length() - 2);
		}
		return verbString;
	}
	
	public String[] processPronouns(Essay e, List<Pronoun> pronouns) {
		String[] pronounString = new String[pronouns.size()];
		for(int i = 0; i < pronouns.size(); i++) {
			String line = pronouns.get(i).toString(e);
			pronounString[i] = line.substring(1, line.length() - 2);
		}
		return pronounString;
	}
	
	public void writeToFile(String[] lines, File file) {
		try {
			PrintWriter writer = new PrintWriter(file);
			for(String l : lines) {
				writer.println(l);
			}
			writer.close();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
}
