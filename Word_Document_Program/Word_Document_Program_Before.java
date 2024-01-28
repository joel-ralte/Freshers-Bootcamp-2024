import java.util.*;

class WordDocument {
    ArrayList<DocumentPart> DocPartList;
    Iconverter converterObj = new HTMLConverter();
    
    WordDocument(ArrayList<DocumentPart> list) {
        DocPartList = list;
    }
    public void open() {
        System.out.println("Opened document");
    }
    public void save() {
        System.out.println("Saved document");
    }
    public void convert() {
        for(int i=0; i<DocPartList.size(); i++){
            DocPartList.get(i).convert(converterObj);
        }
    }
}
interface Iconverter {
    public void convert(Paragraph paragraphItem);
    public void convert(Hyperlink hyperlinkItem);
    public void convert(Header headerItem);
    public void convert(Footer footerItem);
}
class HTMLConverter implements Iconverter{
    public void convert(Paragraph paragraphItem) {
        System.out.println("Converted paragraph");
    }
    public void convert(Hyperlink hyperlinkItem) {
        System.out.println("Converted hyperlink");
    }
    public void convert(Header headerItem) {
        System.out.println("Converted header");
    }
    public void convert(Footer footerItem) {
        System.out.println("Converted footer");
    }
}
abstract class DocumentPart {
    String name;
    String position;
    abstract void paint();
    abstract void save();
    abstract void convert(Iconverter IC);
}
class Paragraph extends DocumentPart {
    String content;
    
    public Paragraph(String inputText) {
        content = inputText;
    }
    void paint() {
        System.out.println("Painted paragraph");
    }
    void save() {
        System.out.println("Saved paragraph");
    }
    void convert(Iconverter IC) {
        IC.convert(this);
    }
}
class Hyperlink extends DocumentPart {
    String link;
    
    public Hyperlink(String inputText) {
        link = inputText;
    }
    void paint() {
        System.out.println("Painted hyperlink");
    }
    void save() {
        System.out.println("Saved hyperlink");
    }
    void convert(Iconverter IC) {
        IC.convert(this);
    }
}
class Header extends DocumentPart {
    String title;
    
    public Header(String inputText) {
        title = inputText;
    }
    void paint() {
        System.out.println("Painted header");
    }
    void save() {
        System.out.println("Saved header");
    }
    void convert(Iconverter IC) {
        IC.convert(this);
    }
}
class Footer extends DocumentPart {
    String text;
    
    public Footer(String inputText) {
        text = inputText;
    }
    void paint() {
        System.out.println("Painted footer");
    }
    void save() {
        System.out.println("Saved footer");
    }
    void convert(Iconverter IC) {
        IC.convert(this);
    }
}
class Main {
    public static void main(String[] args) {
        ArrayList<DocumentPart> DocPartList = new ArrayList<>();
        
        Paragraph paragraphObj = new Paragraph();
        Hyperlink hyperlinkObj = new Hyperlink();
        Header headerObj = new Header();
        Footer footerObj = new Footer();
        
        DocPartList.add(paragraphObj);
        DocPartList.add(hyperlinkObj);
        DocPartList.add(headerObj);
        DocPartList.add(footerObj);
        
        WordDocument wordDocObj = new WordDocument(DocPartList);
        wordDocObj.convert();
    }
}
