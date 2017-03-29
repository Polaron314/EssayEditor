package edu.sacredheart.jtowner.nlp;

import java.util.List;

public class DocumentCreator {
	
	public DocumentCreator() {
		
	}
	
	public String[] processVerbs(Essay e, List<Verb> verbs) {
		String[] verbString = new String[verbs.size()];
		for(int i = 0; i < verbs.size(); i++) {
			verbString[i] = verbs.get(i).toString(e);
		}
		return verbString;
	}
	
	public String[] processPronouns(Essay e, List<Verb> verbs) {
		String[] verbString = new String[verbs.size()];
		for(int i = 0; i < verbs.size(); i++) {
			verbString[i] = verbs.get(i).toString(e);
		}
		return verbString;
	}
	
}
