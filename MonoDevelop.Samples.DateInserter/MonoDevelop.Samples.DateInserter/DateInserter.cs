using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Ide.Gui.Content;
using Mono.TextEditor;
using MonoDevelop.Ide;

namespace MonoDevelop.Samples.DateInserter
{
	public enum DateInserterCommands
	{
		InsertDate,
	}

	class InsertDateHandler : CommandHandler
	{
		protected override void Run ()
		{
			MonoDevelop.Ide.Gui.Document doc = IdeApp.Workbench.ActiveDocument;
			var textEditorData = doc.GetContent<ITextEditorDataProvider> ().GetTextEditorData ();
			string date = DateTime.Now.ToString ();
			textEditorData.InsertAtCaret (date);
		}
		
		protected override void Update (CommandInfo info)
		{
			MonoDevelop.Ide.Gui.Document doc = IdeApp.Workbench.ActiveDocument;
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;
		}   
	}
}

