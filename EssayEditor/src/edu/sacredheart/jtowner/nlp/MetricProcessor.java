package edu.sacredheart.jtowner.nlp;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;

public class MetricProcessor {
	
	String PUNCT = ".,:;?!";
	List<String> pronouns = new ArrayList<String>();
	
	public MetricProcessor() {
		this.loadPronouns();
	}
	
	public void loadPronouns() {
		try {
			BufferedReader br = new BufferedReader(new InputStreamReader(new FileInputStream("pronouns.txt")));
			String line;
			while ((line = br.readLine()) != null) {
		        pronouns.add(line);
		    }
			br.close();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public int getWordCount(String rawText) {
		String[] words = rawText.split(" ");
		return words.length;
	}
	
	public int[] getSentenceLength(String[] sentences) {
		int[] len = new int[sentences.length];
		for(int i = 0; i < sentences.length; i++) {
			String sentence = sentences[i];
			int length = sentence.split(" ").length;
			len[i] = length;
		}
		return len;
	}
	
	public LinkedHashMap<String, Integer> getWordFrequency(String[][] tokens) {
		LinkedHashMap<String, Integer> freq = new LinkedHashMap<String, Integer>();
		for(String[] sentence : tokens) {
			for (String word : sentence) {
				if(!PUNCT.contains(word)) {
					Integer n = freq.get(word.toLowerCase());
					n = (n == null) ? 1 : ++n;
					freq.put(word.toLowerCase(), n);
				}
			}
		}
		return this.sortValue(freq);
	}
	
	public HashMap<String, List<Location>> getPronounUsage(String[][] tokens) {
		HashMap<String, List<Location>> pronounUsage = new HashMap<String, List<Location>>();
		for(int i = 0; i < tokens.length; i++) {
			for(int j = 0; j < tokens[i].length; j++) {
				if(pronouns.contains(tokens[i][j])) {
					Location l = new Location(i,j,tokens[i][j].length());
					List<Location> locations = pronounUsage.get(tokens[i][j]);
					if(locations == null) {
						locations = new ArrayList<Location>();
					}
					locations.add(l);
					pronounUsage.put(tokens[i][j], locations);
				}
			}
		}
		
		return pronounUsage;
	}
	
	public HashMap<String, List<Location>> getPunctuationUsage(String[][] tokens) {
		HashMap<String, List<Location>> punctuationUsage = new HashMap<String, List<Location>>();
		for(int i = 0; i < tokens.length; i++) {
			for(int j = 0; j < tokens[i].length; j++) {
				if(PUNCT.contains(tokens[i][j])) {
					Location l = new Location(i,j,tokens[i][j].length());
					List<Location> locations = punctuationUsage.get(tokens[i][j]);
					if(locations == null) {
						locations = new ArrayList<Location>();
					}
					locations.add(l);
					punctuationUsage.put(tokens[i][j], locations);
				}
			}
		}
		
		return punctuationUsage;
	}
	
	public LinkedHashMap<String, Integer> sortValue(LinkedHashMap<String, Integer> t){
	       ArrayList<Map.Entry<String, Integer>> l = new ArrayList<Entry<String, Integer>>(t.entrySet());
	       Collections.sort(l, new Comparator<Map.Entry<String, Integer>>(){

	         public int compare(Map.Entry<String, Integer> o1, Map.Entry<String, Integer> o2) {
	            return o1.getValue().compareTo(o2.getValue());
	        }});
	       LinkedHashMap<String,Integer> map = new LinkedHashMap<>();
	       for(int i = l.size() - 1; i > -1; i--) {
	    	   map.put(l.get(i).getKey(), l.get(i).getValue());
	       }
	       return map;
	    }
}


