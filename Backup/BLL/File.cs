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
using Blogo.DBUtility;
using Blogo.IDAL;

using Blogo.SQLServerDAL;
using Blogo.AccessDAL;
using Blogo.DALFactory;



namespace Blogo.BLL
{
	///
	//File
	///
	public static class FileManager
	{
		private static Blogo.IDAL.IFile dal=Blogo.DALFactory.DataAccess.CreateFile();
		
		public static  FileEntity SelectFileByID(int t_id)
		{
			FileEntity temp=null;
			try
			{
				temp=dal.SelectFileByID( t_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return temp;
		}
		
		public static IList<FileEntity> GetAllFile()
		{
			IList<FileEntity> temp=null;
			try
			{
				temp=GetAllFile();
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
		
		
		public static IList<FileEntity> GetAllFileByauthor_id(int t_author_id)
		{
			IList<FileEntity> temp=null;
			try
			{
				temp=GetAllFileByauthor_id(t_author_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			
			return temp;
		}
	
		public  static int InsertFile(FileEntity t_File)
		{		
			int i=-1;
			try
			{
				i=InsertFile(t_File);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;				
		}
		
		public static int UpdateFile(FileEntity t_File)
		{
			int i=-1;
			try
			{
				i=UpdateFile(t_File);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
		
		public static int DeleteFile(int t_id)
		{
			int i=-1;
			try
			{
				i=DeleteFile(t_id);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return i;	
		}
	}
}


