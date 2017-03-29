package edu.sacredheart.jtowner.nlp;

public class Main {
	public static void main(String[] args) {
		DocumentCreator dc = new DocumentCreator();
		Essay e = new Essay("essay.txt");
		e.process();
	}
	
	public static void getInfo(Essay e) {
		
	}
}
