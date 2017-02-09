///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

using Blogo.Model;


namespace Blogo.IDAL
{
	///
	//File
	///
	public interface IFile
	{
		 FileEntity SelectFileByID(int t_id);
		
		 IList<FileEntity> GetAllFile();
				
		 IList<FileEntity> GetAllFileByauthor_id(int t_author_id);
		
	
		  int InsertFile(FileEntity t_File);
		
		  int UpdateFile(FileEntity t_File);
		
		  int DeleteFile(int t_id);
	}
}


