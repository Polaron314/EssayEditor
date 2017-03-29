package edu.sacredheart.jtowner.nlp;

public class Location {
	
	private int sentence;
	private int tokenStart;
	protected int length;
	
	public Location(int sentence, int tokenStart, int tokens) {
		this.sentence = sentence;
		this.tokenStart = tokenStart;
		this.length = tokens;
	}
	
	@Override
	public String toString() {
		return "{" + sentence + ": " + tokenStart + "," + (length) + "}";
	}
	
	int getSentence() {
		return sentence;
	}
	
	int getTokenStart() {
		return tokenStart;
	}
	
	int getLength() {
		return length;
	}
	
	public boolean doesContain(int sentence, int token) {
		if(sentence == this.sentence) {
			if(token >= tokenStart && token < tokenStart + length) {
				return true;
			}
		}
		return false;
	}
	
}
