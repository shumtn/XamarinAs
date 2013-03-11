using MonoDevelop.Core;
//using MonoDevelop.D.Building;
using MonoDevelop.Projects;

namespace MonoDevelop.Lua
{
	public class LuaLanguageBinding : ILanguageBinding
	{
		public static LuaLanguageBinding Instance { get; private set; }

		public LuaLanguageBinding ()
		{
			Instance = this;
		}

		~LuaLanguageBinding()
		{

		}

		public static bool IsDFile(string fileName)
		{
			return fileName.EndsWith(".lua", System.StringComparison.OrdinalIgnoreCase);
		}
		
		public FilePath GetFileName(FilePath fileNameWithoutExtension)
		{
			return fileNameWithoutExtension.ChangeExtension(".lua");
		}

		public bool IsSourceCodeFile(FilePath fileName)
		{
			return false;
		}

		public string Language
		{
			get { return "Lua"; }
		}
		
		public string SingleLineCommentTag
		{
			get { return "//"; }
		}
		
		public string BlockCommentStartTag
		{
			get { return "/*"; }
		}
		
		public string BlockCommentEndTag
		{
			get { return "*/"; }
		}
	}
}

