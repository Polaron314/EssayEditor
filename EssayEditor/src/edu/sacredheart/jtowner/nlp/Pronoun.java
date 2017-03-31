package edu.sacredheart.jtowner.nlp;

public class Pronoun extends Location {
	
	private int person;
	private String pronoun;
	
	public Pronoun(int sentence, int tokenStart, int length, String pronoun) {
		super(sentence, tokenStart, length);
		this.pronoun = pronoun;
		this.person = this.pronounToPerson(pronoun);
	}
	
	public Pronoun(int sentence, int tokenStart, int length, int person, String pronoun) {
		super(sentence, tokenStart, length);
		this.person = person;
	}
	
	public String toString(Essay e) {
		int start = e.getSpan(sentence, tokenStart).getStart();
		int end = e.getSpan(sentence, tokenStart + length - 1).getEnd();
		return "{"+ sentence + "," + start + "," + end + "," + person + "," + pronoun + "}";
	}
	
	private int pronounToPerson(String s) {
		switch(s) {
		case "i": case "me": case "my": case "mine": case "myself":
			return 1;
		case "you": case "your": case "yours": case "yourself":
			return 2;
		case "he": case "him": case "his": case "himself": case "she": case "her": case "hers": case "herself":
			return 3;
		case "it":case"its":case "itself":case"they":case"them":case"their":case"theirs":
			return 3;
		case "we": case "us": case "our":case "ourselves":
			return 1;
		}
		return 0;
	}
	
}
