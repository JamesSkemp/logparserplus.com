<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.EnterpriseServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.RegularExpressions.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Design.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.ApplicationServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ComponentModel.DataAnnotations.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.Protocols.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Caching.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ServiceProcess.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.Services.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.Build.Utilities.v4.0.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.Build.Framework.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Microsoft.Build.Tasks.v4.0.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
</Query>

var xmlPath = @"C:\Users\James\Projects\Standalone\LogParserPlus\LogParserPlus.Web\App_Data\functions.xml";
var mdPath = @"C:\Users\James\Projects\logparserplus.com\content\functions\";

var xmlItems = XDocument.Load(xmlPath).Descendants("function");

var filePath = "";
foreach (var xmlItem in xmlItems)
{
	filePath = mdPath + xmlItem.Element("name").Value.ToLower() + ".md";
	
	if (File.Exists(filePath))
	{
		File.Delete(filePath);
	}
	
	var fileData = new StringBuilder();
	fileData.AppendLine("+++");
	fileData.AppendFormat("name = \"{0}\"" + Environment.NewLine, xmlItem.Element("name").Value);
	var syntaxRaw = System.Web.HttpUtility.HtmlDecode(xmlItem.Element("syntax").Value);
	fileData.AppendFormat("syntax = \"{0}\"" + Environment.NewLine, syntaxRaw);
	fileData.AppendFormat("description = \"{0}\"" + Environment.NewLine, xmlItem.Element("description").Value);
	fileData.AppendFormat("type = \"{0}\"" + Environment.NewLine, xmlItem.Element("type").Value);

	// Related.
	var relatedItems = xmlItem.Elements("related").Select(e => e.Value).Where(e => !string.IsNullOrWhiteSpace(e));
	if (relatedItems.Any())
	{
		fileData.AppendFormat("related = [\"{0}\"]" + Environment.NewLine, string.Join("\", \"", relatedItems));
	}
	
	//fileData.AppendFormat(" = \"{0}\"" + Environment.NewLine, xmlItem.Element("").Value);
	fileData.AppendLine("+++");
	fileData.AppendLine("");

	var examples = xmlItem.Element("examples").Descendants().Where(e => !string.IsNullOrWhiteSpace(e.Value));
	if (examples.Any())
	{
		examples.Dump();
		fileData.AppendLine("#### Examples");
		foreach (var example in examples)
		{
			fileData.AppendFormat("- {0}{1}"
				, example.Value
					.Replace("<span>", "`")
					.Replace("</span>", "`  " + Environment.NewLine + " ")
				, Environment.NewLine);
		}
		
	}

	// Examples.


	fileData.ToString().Dump();
	File.WriteAllText(filePath, fileData.ToString());
}



xmlItems.Dump();


