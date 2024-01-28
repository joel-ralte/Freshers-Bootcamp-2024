using System;
using System.Collections.Generic;

class WordDocument
{
    List<DocumentPart> DocPartList;
    IConverter converterObj = new HTMLConverter();

    public WordDocument(List<DocumentPart> list)
    {
        DocPartList = list;
    }

    public void Open()
    {
        Console.WriteLine("Opened document");
    }

    public void Save()
    {
        Console.WriteLine("Saved document");
    }

    public void Convert()
    {
        foreach (var part in DocPartList)
        {
            part.Convert(converterObj);
        }
    }
}

interface IConverter
{
    void Convert(Paragraph paragraphItem);
    void Convert(Hyperlink hyperlinkItem);
    void Convert(Header headerItem);
    void Convert(Footer footerItem);
}

class HTMLConverter : IConverter
{
    public void Convert(Paragraph paragraphItem)
    {
        Console.WriteLine("Converted paragraph");
    }

    public void Convert(Hyperlink hyperlinkItem)
    {
        Console.WriteLine("Converted hyperlink");
    }

    public void Convert(Header headerItem)
    {
        Console.WriteLine("Converted header");
    }

    public void Convert(Footer footerItem)
    {
        Console.WriteLine("Converted footer");
    }
}

abstract class DocumentPart
{
    public string Name { get; set; }
    public string Position { get; set; }

    public abstract void Paint();
    public abstract void Save();
    public abstract void Convert(IConverter IC);
}

class Paragraph : DocumentPart
{
    public string Content { get; set; }

    public Paragraph(string inputText)
    {
        Content = inputText;
    }

    public override void Paint()
    {
        Console.WriteLine("Painted paragraph");
    }

    public override void Save()
    {
        Console.WriteLine("Saved paragraph");
    }

    public override void Convert(IConverter IC)
    {
        IC.Convert(this);
    }
}

class Hyperlink : DocumentPart
{
    public string Link { get; set; }

    public Hyperlink(string inputText)
    {
        Link = inputText;
    }

    public override void Paint()
    {
        Console.WriteLine("Painted hyperlink");
    }

    public override void Save()
    {
        Console.WriteLine("Saved hyperlink");
    }

    public override void Convert(IConverter IC)
    {
        IC.Convert(this);
    }
}

class Header : DocumentPart
{
    public string Title { get; set; }

    public Header(string inputText)
    {
        Title = inputText;
    }

    public override void Paint()
    {
        Console.WriteLine("Painted header");
    }

    public override void Save()
    {
        Console.WriteLine("Saved header");
    }

    public override void Convert(IConverter IC)
    {
        IC.Convert(this);
    }
}

class Footer : DocumentPart
{
    public string Text { get; set; }

    public Footer(string inputText)
    {
        Text = inputText;
    }

    public override void Paint()
    {
        Console.WriteLine("Painted footer");
    }

    public override void Save()
    {
        Console.WriteLine("Saved footer");
    }

    public override void Convert(IConverter IC)
    {
        IC.Convert(this);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        List<DocumentPart> DocPartList = new List<DocumentPart>();

        Paragraph paragraphObj = new Paragraph("Sample Paragraph");
        Hyperlink hyperlinkObj = new Hyperlink("http://example.com");
        Header headerObj = new Header("Document Header");
        Footer footerObj = new Footer("Document Footer");

        DocPartList.Add(paragraphObj);
        DocPartList.Add(hyperlinkObj);
        DocPartList.Add(headerObj);
        DocPartList.Add(footerObj);

        WordDocument wordDocObj = new WordDocument(DocPartList);
        wordDocObj.Convert();
    }
}
