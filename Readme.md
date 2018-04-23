# Custom editor: How to create a custom HyperLinkEdit with the AutoHeight functionality


<p>When the GridView's <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridOptionsView_RowAutoHeighttopic">GridOptionsView.RowAutoHeight </a> option is enabled, GridView obtains the result of the IHeightAdaptable.CalcHeight() method to calculate the preferred row height. This example illustrates how to implement the IHeightAdaptable interface in a HyperLinkEdit editor, so rows height is calculated based on the size of the text in cells.</p>

<br/>


