package edu.sacredheart.jtowner.nlp;

import static com.tutego.jrtf.Rtf.rtf;
import static com.tutego.jrtf.RtfDocfmt.*;
import static com.tutego.jrtf.RtfHeader.*;
import static com.tutego.jrtf.RtfInfo.*;
import static com.tutego.jrtf.RtfFields.*;
import static com.tutego.jrtf.RtfPara.*;
import static com.tutego.jrtf.RtfSectionFormatAndHeaderFooter.*;
import static com.tutego.jrtf.RtfText.*;
import static com.tutego.jrtf.RtfUnit.*;

import java.io.FileWriter;
import java.io.IOException;

public class DocumentCreator {
	
	Essay essay;
	
	public DocumentCreator() {
		//this.essay = e;
	}
	
	public void exportSentences() {
		try {
			FileWriter out = new FileWriter("out.rtf");
			
		} catch (Exception e) {
			
		}
	}
	
}
