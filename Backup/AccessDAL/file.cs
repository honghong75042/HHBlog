///
//?????,?????CodeSmith??
//???:??
//????:2010?1?24?
///

using System.Data;
using System.Collections.Generic;
using System.Data.OleDb;
using System;

using Blogo.Model;
using Blogo.DBUtility;
using Blogo.IDAL;


namespace Blogo.AccessDAL
{
	///
	//File
	///
	public class File:IFile
	{
		public  FileEntity SelectFileByID(int t_id)
		{
			FileEntity t_File=new FileEntity();
			OleDbDataReader sdr =null;
			using(sdr=OLEDBHelp.GetReader("select * from Files where id="+t_id))
			{
				if(sdr.Read())
				{
					t_File.Id=(int)sdr.GetValue(0);
					t_File.Filename=(string)sdr.GetValue(1);
					t_File.Mime=(string)sdr.GetValue(2);
					t_File.Filecontent=(byte[])sdr.GetValue(3);
					t_File.Author_id=(int)sdr.GetValue(4);
					
				}
				
			}
			sdr.Close();
			
			return t_File;
		}
		
		public IList<FileEntity> GetAllFile()
		{
			IList<FileEntity> t_Files=new List<FileEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Files"))
			{
				while(sdr.Read())
				{
					FileEntity t_File=new FileEntity();
					t_File.Id=(int)sdr.GetValue(0);					
					t_File.Filename=(string)sdr.GetValue(1);					
					t_File.Mime=(string)sdr.GetValue(2);					
					t_File.Filecontent=(byte[])sdr.GetValue(3);					
					t_File.Author_id=(int)sdr.GetValue(4);					
					t_Files.Add(t_File);
				}
				sdr.Close();
			}
			
			return t_Files;
		}
		
		
		public IList<FileEntity> GetAllFileByauthor_id(int t_author_id)
		{
			IList<FileEntity> t_Files=new List<FileEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Files where author_id="+t_author_id))
			{
				while(sdr.Read())
				{
					FileEntity t_File=new FileEntity();
					t_File.Id=(int)sdr.GetValue(0);
					t_File.Filename=(string)sdr.GetValue(1);
					t_File.Mime=(string)sdr.GetValue(2);
					t_File.Filecontent=(byte[])sdr.GetValue(3);
					t_File.Author_id=(int)sdr.GetValue(4);
					t_Files.Add(t_File);
				}
				sdr.Close();
			}
			
			return t_Files;
		}
	
		public  int InsertFile(FileEntity t_File)
		{			
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Id",t_File.Id),					
				new OleDbParameter("@Filename",t_File.Filename),					
				new OleDbParameter("@Mime",t_File.Mime),					
				new OleDbParameter("@Filecontent",t_File.Filecontent),					
				new OleDbParameter("@Author_id",t_File.Author_id)				
				
			};
			
			int i=OLEDBHelp.GetExecute("insert into Files values(@Id,@Filename,@Mime,@Filecontent,@Author_id)",p);
			return i;				
		}
		
		public  int UpdateFile(FileEntity t_File)
		{
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Id",t_File.Id),					
				new OleDbParameter("@Filename",t_File.Filename),					
				new OleDbParameter("@Mime",t_File.Mime),					
				new OleDbParameter("@Filecontent",t_File.Filecontent),					
				new OleDbParameter("@Author_id",t_File.Author_id)				
				
			};
			
			int i=OLEDBHelp.GetExecute("update Files set filename=@Filename,mime=@Mime,filecontent=@Filecontent,author_id=@Author_id where id=@Id",p);
			return i;	
		}
		
		public  int DeleteFile(int t_id)
		{
			int i=OLEDBHelp.GetExecute("delete from Files where id="+t_id);
			return i;
		}
	}
}


