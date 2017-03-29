package edu.sacredheart.jtowner.nlp;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class VerbProcessor {
	
	private String[][] sentences;
	private String[][] tags;
	private List<Verb> verbs = new ArrayList<Verb>();
	
	public VerbProcessor() {
		
	}
	
	public List<Verb> process(String[][] sentences, String[][] tags) {
		this.sentences = sentences;
		this.tags = tags;
		for(int i = 0; i < sentences.length; i++) {
			String[][] stuff = this.removeAdverbs(this.sentences[i], this.tags[i]);
			this.processAllVerbs(stuff[0], stuff[1], i);
		}
		this.fixAdverbs(sentences, tags);
		return verbs;
	}
	
	public String[][] removeAdverbs(String[] sentence, String[] tags) {
		List<String> sentenceList = new LinkedList<String>(Arrays.asList(sentence));
		List<String> tagList = new LinkedList<String>(Arrays.asList(tags));
		for(int i = sentenceList.size() - 1; i >= 0; i--) {
			if(tags[i].contains("RB")) {
				sentenceList.remove(i);
				tagList.remove(i);
			}
		}
		String[][] stuff = new String[2][];
		stuff[0] = sentenceList.toArray(new String[sentenceList.size()]);
		stuff[1] = tagList.toArray(new String[tagList.size()]);
		return stuff;
	}
	
	public void fixAdverbs(String[][] sentences, String[][] tags) {
		for(int i = 0; i < sentences.length; i++) {
			for(int j = 0; j < sentences[i].length; j++) {
				if(tags[i][j].contains("RB")) {
					for(Verb v : verbs) {
						if(v.doesContain(i, j)) {
							v.increaseLength();
						}
					}
				}
			}
		}
	}
	
	public void processAllVerbs(String[] sentence, String[] tags, int sentenceNum) {
		List<String> sl = new LinkedList<String>(Arrays.asList(sentence));
		List<String> tl = new LinkedList<String>(Arrays.asList(tags));
		int[] tenses = new int[3];
		int[] voices = new int[2];
		for(int i = sl.size() - 1; i >= 0; i--) {
			String t = tl.get(i);
			switch(t) {
			case "VBP":
				tenses[1]++;
				voices[0]++;
				this.addVerb(sentenceNum, i, 1, 0, 1);
				sl.remove(i);
				tl.remove(i);
				break;
			case "VBZ":
				tenses[1]++;
				voices[0]++;
				this.addVerb(sentenceNum, i, 1, 0, 1);
				sl.remove(i);
				tl.remove(i);
				break;
			case "VBD":
				if(i > 2 && sl.get(i - 1).equals("being") && sl.get(i - 2).equals("be") && sl.get(i - 3).equals("will")) {
					tenses[2]++;
					voices[1]++;
					this.addVerb(sentenceNum, i - 3, 4, 1, 2);
					sl.remove(i);
					tl.remove(i);
					sl.remove(i-1);
					tl.remove(i-1);
					sl.remove(i-2);
					tl.remove(i-2);
					sl.remove(i-3);
					tl.remove(i-3);
					i -= 3;
				} else if(i > 1 && sl.get(i - 1).equals("being") && (sl.get(i - 2).equals("was")||sl.get(i - 2).equals("were"))){
					tenses[0]++;
					voices[1]++;
					this.addVerb(sentenceNum, i - 2, 3, 1, 0);
					sl.remove(i);
					tl.remove(i);
					sl.remove(i-1);
					tl.remove(i-1);
					sl.remove(i-2);
					tl.remove(i-2);
					i -= 2;
				} else {
					tenses[0]++;
					voices[0]++;
					this.addVerb(sentenceNum, i, 1, 0, 0);
					sl.remove(i);
					tl.remove(i);
				}
				break;
			case "VB":
				if(i != 0 && sl.get(i - 1).equals("will")) {
					tenses[2]++;
					voices[0]++;
					this.addVerb(sentenceNum, i - 1, 2, 0, 2);
					sl.remove(i);
					tl.remove(i);
					sl.remove(i - 1);
					tl.remove(i - 1);
					i--;
				}
				break;
			case "VBG":
				if(i != 0) {
					switch(sl.get(i - 1)) {
					case "is": case "are": case "am":
						tenses[1]++;
						voices[0]++;
						this.addVerb(sentenceNum, i - 1, 2, 0, 1);
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "been":
						if(i > 1 && sl.get(i - 2).equals("has")||sl.get(i - 2).equals("have")) {
							if(i > 2 && sl.get(i - 3).equals("will")) {
								tenses[2]++;
								voices[0]++;
								this.addVerb(sentenceNum, i - 3, 4, 0, 2);
								sl.remove(i);
								tl.remove(i);
								sl.remove(i - 1);
								tl.remove(i - 1);
								sl.remove(i - 2);
								tl.remove(i - 2);
								sl.remove(i - 3);
								tl.remove(i - 3);
								i-=3;
							} else{
								tenses[1]++;
								voices[0]++;
								this.addVerb(sentenceNum, i - 2, 3, 0, 1);
								sl.remove(i);
								tl.remove(i);
								sl.remove(i - 1);
								tl.remove(i - 1);
								sl.remove(i - 2);
								tl.remove(i - 2);
								i-=2;
							}
						} else if(i > 1 && sl.get(i - 2).equals("had")) {
							tenses[0]++;
							voices[0]++;
							this.addVerb(sentenceNum, i - 2, 3, 0, 0);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							sl.remove(i - 2);
							tl.remove(i - 2);
							i-=2;
						}
						break;
					case "was": case "were":
						tenses[0]++;
						voices[0]++;
						this.addVerb(sentenceNum, i - 1, 2, 0, 0);
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "be":
						if(i > 1 && sl.get(i - 2).equals("will")) {
							tenses[2]++;
							voices[0]++;
							this.addVerb(sentenceNum, i - 2, 3, 0, 2);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							sl.remove(i - 2);
							tl.remove(i - 2);
							i-=2;
						} else if(i > 1 && tl.get(i - 2).equals("MD")) {
							tenses[1]++;
							voices[0]++;
							this.addVerb(sentenceNum, i - 2, 3, 0, 1);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							sl.remove(i - 2);
							tl.remove(i - 2);
							i-=2;
						}
						break;
					}
				}
				break;
			case "VBN":
				if(i != 0) {
					switch(sl.get(i - 1)) {
					case "has": case "have":
						if(i > 1 && sl.get(i - 2).equals("will")) {
							tenses[2]++;
							voices[0]++;
							this.addVerb(sentenceNum, i - 2, 3, 0, 2);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							sl.remove(i - 2);
							tl.remove(i - 2);
							i-=2;
						} else {
							tenses[1]++;
							voices[0]++;
							this.addVerb(sentenceNum, i - 1, 2, 0, 1);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							i--;
						}
						break;
					case "had":
						tenses[0]++;
						voices[0]++;
						this.addVerb(sentenceNum, i - 1, 2, 0, 0);
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "be":
						if(i > 1 && sl.get(i-2).equals("will")) {
							tenses[2]++;
							voices[1]++;
							this.addVerb(sentenceNum, i - 2, 3, 1, 2);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							sl.remove(i - 2);
							tl.remove(i - 2);
							i-=2;
						} else if (i > 1 && tl.get(i-2).equals("MD")) {
							tenses[1]++;
							voices[1]++;
							this.addVerb(sentenceNum, i - 2, 3, 1, 1);
							sl.remove(i);
							tl.remove(i);
							sl.remove(i - 1);
							tl.remove(i - 1);
							sl.remove(i - 2);
							tl.remove(i - 2);
							i-=2;
						}
						break;
					case "was": case "were":
						tenses[0]++;
						voices[0]++;
						this.addVerb(sentenceNum, i - 1, 2, 0, 0);
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "is": case "are": case "am":
						tenses[1]++;
						voices[1]++;
						this.addVerb(sentenceNum, i - 1, 2, 1, 1);
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "being":
						if(i > 1) {
							switch(sl.get(i - 2)) {
							case "is": case "are": case "am":
								tenses[1]++;
								voices[1]++;
								this.addVerb(sentenceNum, i - 2, 3, 1, 1);
								sl.remove(i);
								tl.remove(i);
								sl.remove(i - 1);
								tl.remove(i - 1);
								sl.remove(i - 2);
								tl.remove(i - 2);
								i-=2;
								break;
							case "was": case "were":
								tenses[0]++;
								voices[1]++;
								this.addVerb(sentenceNum, i - 2, 3, 1, 0);
								sl.remove(i);
								tl.remove(i);
								sl.remove(i - 1);
								tl.remove(i - 1);
								sl.remove(i - 2);
								tl.remove(i - 2);
								i-=2;
								break;
							case "be":
								if(i > 2 && sl.get(i-3).equals("will")) {
									tenses[2]++;
									voices[1]++;
									this.addVerb(sentenceNum, i - 3, 4, 1, 2);
									sl.remove(i);
									tl.remove(i);
									sl.remove(i - 1);
									tl.remove(i - 1);
									sl.remove(i - 2);
									tl.remove(i - 2);
									sl.remove(i - 3);
									tl.remove(i - 3);
									i-=3;
								}
							}
						}
						break;
					case "been":
						if(i > 1) {
							switch(sl.get(i - 2)) {
							case "has": case "have":
								if(i > 2 && sl.get(i-3).equals("will")) {
									tenses[1]++;
									voices[1]++;
									this.addVerb(sentenceNum, i - 3, 4, 1, 1);
									sl.remove(i);
									tl.remove(i);
									sl.remove(i - 1);
									tl.remove(i - 1);
									sl.remove(i - 2);
									tl.remove(i - 2);
									sl.remove(i - 3);
									tl.remove(i - 3);
									i-=3;
								} else {
									tenses[0]++;
									voices[1]++;
									this.addVerb(sentenceNum, i - 2, 3, 1, 0);
									sl.remove(i);
									tl.remove(i);
									sl.remove(i - 1);
									tl.remove(i - 1);
									sl.remove(i - 2);
									tl.remove(i - 2);
									i-=2;
								}
								break;
							case "had":
								tenses[0]++;
								voices[1]++;
								this.addVerb(sentenceNum, i - 2, 3, 1, 0);
								sl.remove(i);
								tl.remove(i);
								sl.remove(i - 1);
								tl.remove(i - 1);
								sl.remove(i - 2);
								tl.remove(i - 2);
								i-=2;
								break;
							}
						}
						break;
					}
				}
			}
		}
	}
	
	private void addVerb(int sentence, int location, int tokenLength, int voice, int tense) {
		this.verbs.add(new Verb(sentence, location, tokenLength, voice, tense));
	}
}
