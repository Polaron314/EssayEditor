package edu.sacredheart.jtowner.nlp;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class VerbProcessor {
	
	private String[] sentence;
	private String[] tags;
	
	public VerbProcessor() {
		
	}
	
	public int[] process(String[] sentence, String[] tags) {
		System.out.println(Arrays.toString(sentence));
		System.out.println(Arrays.toString(tags));
		this.sentence = sentence;
		this.tags = tags;
		this.removeAdverbs();
		return this.processAllVerbs();
	}
	
	public void removeAdverbs() {
		List<String> sentenceList = new LinkedList<String>(Arrays.asList(sentence));
		List<String> tagList = new LinkedList<String>(Arrays.asList(tags));
		for(int i = sentenceList.size() - 1; i >= 0; i--) {
			if(tags[i].contains("RB")) {
				sentenceList.remove(i);
				tagList.remove(i);
			}
		}
		this.sentence = sentenceList.toArray(new String[sentenceList.size()]);
		this.tags = tagList.toArray(new String[tagList.size()]);
	}
	
	public int[] processAllVerbs() {
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
				sl.remove(i);
				tl.remove(i);
				break;
			case "VBZ":
				tenses[1]++;
				voices[0]++;
				sl.remove(i);
				tl.remove(i);
				break;
			case "VBD":
				if(i > 2 && sl.get(i - 1).equals("being") && sl.get(i - 2).equals("be") && sl.get(i - 3).equals("will")) {
					tenses[2]++;
					voices[1]++;
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
					sl.remove(i);
					tl.remove(i);
				}
				break;
			case "VB":
				if(i != 0 && sl.get(i - 1).equals("will")) {
					tenses[2]++;
					voices[0]++;
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
					case "is": case "are":
						tenses[1]++;
						voices[0]++;
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
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "is": case "are":
						tenses[1]++;
						voices[1]++;
						sl.remove(i);
						tl.remove(i);
						sl.remove(i - 1);
						tl.remove(i - 1);
						i--;
						break;
					case "being":
						if(i > 1) {
							switch(sl.get(i - 2)) {
							case "is": case "are":
								tenses[1]++;
								voices[1]++;
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
		System.out.println(Arrays.toString(voices));
		return tenses;
	}
}
