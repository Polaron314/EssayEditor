package edu.sacredheart.jtowner.nlp;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;

import opennlp.tools.postag.POSModel;
import opennlp.tools.postag.POSTaggerME;
import opennlp.tools.sentdetect.SentenceDetectorME;
import opennlp.tools.sentdetect.SentenceModel;
import opennlp.tools.tokenize.Tokenizer;
import opennlp.tools.tokenize.TokenizerME;
import opennlp.tools.tokenize.TokenizerModel;

public class LanguageProcessor {
	
	public LanguageProcessor() {
		
	}
	
	public String[] tokenizer(String sentence) {
		InputStream modelIn = null;
		try {
		  modelIn = new FileInputStream("en-token.bin");
		  TokenizerModel model = new TokenizerModel(modelIn);
		  Tokenizer tokenizer = new TokenizerME(model);
		  String tokens[] = tokenizer.tokenize(sentence);
		  return tokens;
		}
		catch (IOException e) {
		  e.printStackTrace();
		}
		finally {
		  if (modelIn != null) {
		    try {
		      modelIn.close();
		    }
		    catch (IOException e) {
		    }
		  }
		}
		return null;
	}
	
	public String[] POSTagger(String[] tokenized) {
		InputStream modelIn = null;

		try {
		  modelIn = new FileInputStream("en-pos-maxent.bin");
		  POSModel model = new POSModel(modelIn);
		  POSTaggerME tagger = new POSTaggerME(model);
		  String sent[] = tokenized;	  
		  String tags[] = tagger.tag(sent);
		  return tags;
		}
		catch (IOException e) {
		  // Model loading failed, handle the error
		  e.printStackTrace();
		}
		finally {
		  if (modelIn != null) {
		    try {
		      modelIn.close();
		    }
		    catch (IOException e) {
		    }
		  }
		}
		return null;
	}
	
	public String[] toSentences(String text) {
		InputStream modelIn = null;

		try {
		  modelIn = new FileInputStream("en-sent.bin");
		  SentenceModel model = new SentenceModel(modelIn);
		  SentenceDetectorME sentenceDetector = new SentenceDetectorME(model);
		  String sentences[] = sentenceDetector.sentDetect(text);
		  return sentences;
		}
		catch (IOException e) {
		  // Model loading failed, handle the error
		  e.printStackTrace();
		}
		finally {
		  if (modelIn != null) {
		    try {
		      modelIn.close();
		    }
		    catch (IOException e) {
		    }
		  }
		}
		return null;
	}
	
	
	
}
