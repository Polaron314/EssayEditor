import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Arrays;

import opennlp.tools.postag.POSModel;
import opennlp.tools.postag.POSTaggerME;
import opennlp.tools.sentdetect.SentenceDetectorME;
import opennlp.tools.sentdetect.SentenceModel;
import opennlp.tools.tokenize.Tokenizer;
import opennlp.tools.tokenize.TokenizerME;
import opennlp.tools.tokenize.TokenizerModel;

public class Main {
	
	public static void main(String[] args) {
		try {
			String text = readFile("essay.txt", Charset.defaultCharset());
			String[] sentences = toSentences(text);
			System.out.println(Arrays.toString(sentences));
			String[] tokenized = tokenizer(sentences[0]);
			String[] tagged = POSTagger(tokenized);
			System.out.println(Arrays.toString(tokenized));
			System.out.println(Arrays.toString(tagged));
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	static String readFile(String path, Charset encoding) 
			  throws IOException 
			{
			  byte[] encoded = Files.readAllBytes(Paths.get(path));
			  return new String(encoded, encoding);
			}
	
	public static String[] tokenizer(String sentence) {
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
	
	public static String[] POSTagger(String[] tokenized) {
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
	
	public static String[] toSentences(String text) {
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
