package edu.sacredheart.jtowner.nlp;

public class Pronoun extends Location {
	
	private int person;
	private int number;
	private String pronoun;
	
	public Pronoun(int sentence, int tokenStart, int length, String pronoun) {
		super(sentence, tokenStart, length);
		this.pronoun = pronoun;
		this.person = this.pronounToPerson(pronoun);
		this.number = this.pronounToNumber(pronoun);
	}
	
	public Pronoun(int sentence, int tokenStart, int length, int person, String pronoun) {
		super(sentence, tokenStart, length);
		this.person = person;
	}

	public int getPerson() {
		return person;
	}
	
	public int getNumber() {
		return number;
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
	
	private int pronounToNumber(String s) {
		switch(s) {
		case "i": case "me": case "my": case "mine": case "you": case "your": case "yours": case "yourself": case "he": case "him": 
			return 0;
		case"it":case"its":case "itself": case "his": case "himself": case "she": case "her": case "hers": case "herself":
			return 0;
		case "they":case"them":case"their":case"theirs":case "we": case "us": case "our":case "ourselves":
			return 1;
		}
		return 2;
	}
	
}
