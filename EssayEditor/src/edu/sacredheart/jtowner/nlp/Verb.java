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
}
