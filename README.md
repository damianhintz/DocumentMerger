DocumentMerger v1.0-beta, 25 stycznia 2017
---
Wsadowe scalanie plików

# Cechy

# Pomoc

PdfDocumentMerger /InputFolder: /MergeMethod:CPdf,Sejda,gs /MergeOptions: /Classifier:FileFolder /ArchiveMethod:Delete,Rename,Move,Zip

cpdf.exe -merge -i 1.pdf 2.pdf -o 1+2.pdf
cpdf.exe -pages 1.pdf

sejda-console.bat merge -f 1.pdf 2.pdf 3.pdf -o 1+2+3.pdf

gs -dBATCH -dNOPAUSE -q -sDEVICE=pdfwrite -sOutputFile=1+2.pdf 1.pdf 2.pdf
gs -dBATCH -dNOPAUSE -q -sDEVICE=pdfwrite -dPDFSETTINGS=/prepress -sOutputFile=1+2.pdf 1.pdf 2.pdf

gswin64c.exe -sDEVICE=pdfwrite -dCompatibilityLevel=1.4 -dPDFSETTINGS=/default -dNOPAUSE -dQUIET -dBATCH 
 -dDetectDuplicateImages 
 -dCompressFonts=true -r300 
 -sOutputFile=1_300.pdf 1.pdf

# Historia

Do zrobienia

* [ ] scalanie plików pdf
 * [ ] scalanie za pomocą programu cpdf
 * [ ] scalanie za pomocą programu sejda
 * [ ] scalanie za pomocą GhostScript
 * [ ] scalanie za pomocą iTextSharp
* [ ] scalanie plików txt

2017-01-25 v1.0-beta

* aktualizacja: platforma docelowa .NET Framework 4 Client Profile

2014-07-25 v1.0-alfa

* propozycja projektu
