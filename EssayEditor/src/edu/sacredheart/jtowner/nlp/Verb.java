package edu.sacredheart.jtowner.nlp;

public class Verb extends Location {

	private int voice;
	private int tense;
	
	public Verb(int sentence, int tokenStart, int length, int voice, int tense) {
		super(sentence, tokenStart, length);
		this.voice = voice;
		this.tense = tense;
	}

	public int getVoice() {
		return voice;
	}
	
	public int getTense() {
		return tense;
	}
	
	public void increaseLength() {
		this.length++;
	}
	
	public String toString(Essay e) {
		int start = e.getSpan(sentence, tokenStart).getStart();
		int end = e.getSpan(sentence, tokenStart + length - 1).getEnd();
		return "{"+ sentence + "," + start + "," + end + "," + voice + "," + tense + "}";
	}
	
	public void offset(int offset) {
		this.tokenStart++;
	}
}
