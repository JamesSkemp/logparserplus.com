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

var xmlPath = @"C:\Users\James\Projects\Standalone\LogParserPlus\LogParserPlus.Web\App_Data\queries.xml";
var mdPath = @"C:\Users\James\Projects\logparserplus.com\content\examples\";

var xmlItems = XDocument.Load(xmlPath).Descendants("query");

var filePath = "";
foreach (var xmlItem in xmlItems)
{
	xmlItem.Dump();
	
	filePath = mdPath + xmlItem.Attribute("id").Value + ".md";

	if (File.Exists(filePath))
	{
		File.Delete(filePath);
	}

	var fileData = new StringBuilder();
	fileData.AppendLine("+++");
	fileData.AppendFormat("id = {0}" + Environment.NewLine, xmlItem.Attribute("id").Value);
	fileData.AppendFormat("name = \"{0}\"" + Environment.NewLine, xmlItem.Element("name").Value);
	fileData.AppendFormat("description = \"{0}\"" + Environment.NewLine, xmlItem.Element("description").Value);
	// Keywords
	var keywords = xmlItem.Element("keywords").Elements("keyword").Select(e => e.Value).Where(e => !string.IsNullOrWhiteSpace(e));
	if (keywords.Any())
	{
		fileData.AppendFormat("keywords = [\"{0}\"]" + Environment.NewLine, string.Join("\", \"", keywords));
	}
	fileData.AppendFormat("statement-parameters = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("parameters").Value);
	fileData.AppendFormat("statement-select = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("select").Value);
	fileData.AppendFormat("statement-using = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("using").Value);
	fileData.AppendFormat("statement-into = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("into").Value);
	fileData.AppendFormat("statement-from = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("from").Value);
	fileData.AppendFormat("statement-where = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("where").Value);
	fileData.AppendFormat("statement-groupby = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("groupBy").Value);
	fileData.AppendFormat("statement-having = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("having").Value);
	fileData.AppendFormat("statement-orderby = \"{0}\"" + Environment.NewLine, xmlItem.Element("statement").Element("orderBy").Value);
	if (!string.IsNullOrWhiteSpace(xmlItem.Element("notes").Value))
	{
		fileData.AppendFormat("notes = \"{0}\"" + Environment.NewLine, xmlItem.Element("notes").Value);
	}




/*
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
	*/
	fileData.AppendLine("+++");
	fileData.AppendLine("");
/*
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
*/

	fileData.ToString().Dump();
	File.WriteAllText(filePath, fileData.ToString());
}



xmlItems.Dump();


