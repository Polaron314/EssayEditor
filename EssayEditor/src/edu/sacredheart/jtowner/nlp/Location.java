package edu.sacredheart.jtowner.nlp;

public class Location {
	
	int sentence;
	int charStart;
	int length;
	
	public Location(int sentence, int charStart, int length) {
		this.sentence = sentence;
		this.charStart = charStart;
		this.length = length;
	}
	
	@Override
	public String toString() {
		return "{" + sentence + ": " + charStart + "," + (length) + "}";
	}
	
}
