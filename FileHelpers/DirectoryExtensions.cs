
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace FileHelpers
{
	public static class DirectoryExtensions
	{
		public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
		{
			if (extensions == null)
			{
				throw new ArgumentNullException("extensions");
			}
			IEnumerable<FileInfo> files = dir.EnumerateFiles();
			return files.Where((f) => extensions.Contains(f.Extension));
		}

	}

}