<!-- default file list -->
*Files to look at*:

* [MyHyperlinkEdit.cs](./CS/WindowsApplication1/CustomEditor/MyHyperlinkEdit.cs) (VB: [MyHyperlinkEdit.vb](./VB/WindowsApplication1/CustomEditor/MyHyperlinkEdit.vb))
* [MyHyperLinkEditPainter.cs](./CS/WindowsApplication1/CustomEditor/MyHyperLinkEditPainter.cs) (VB: [MyHyperLinkEditPainter.vb](./VB/WindowsApplication1/CustomEditor/MyHyperLinkEditPainter.vb))
* [MyHyperLinkEditViewInfo.cs](./CS/WindowsApplication1/CustomEditor/MyHyperLinkEditViewInfo.cs) (VB: [MyHyperLinkEditViewInfo.vb](./VB/WindowsApplication1/CustomEditor/MyHyperLinkEditViewInfo.vb))
* [RepositoryItemMyHyperlinkEdit.cs](./CS/WindowsApplication1/CustomEditor/RepositoryItemMyHyperlinkEdit.cs) (VB: [RepositoryItemMyHyperlinkEdit.vb](./VB/WindowsApplication1/CustomEditor/RepositoryItemMyHyperlinkEdit.vb))
* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# Custom editor: How to create a custom HyperLinkEdit with the AutoHeight functionality


<p>When the GridView's <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridOptionsView_RowAutoHeighttopic">GridOptionsView.RowAutoHeight </a> option is enabled, GridView obtains the result of the IHeightAdaptable.CalcHeight() method to calculate the preferred row height. This example illustrates how to implement the IHeightAdaptable interface in a HyperLinkEdit editor, so rows height is calculated based on the size of the text in cells.</p>

<br/>


