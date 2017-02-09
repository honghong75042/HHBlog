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


namespace Blogo.SQLServerDAL
{
	///
	//File
	///
	public class File:IFile
	{
		public  FileEntity SelectFileByID(int t_id)
		{
			FileEntity t_File=new FileEntity();
			SqlDataReader sdr =null;
			using(sdr=SqlDBHelp.GetReader("select * from Files where id="+t_id))
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
			SqlDataReader sdr=null;
			using(sdr=SqlDBHelp.GetReader("select * from Files"))
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
			SqlDataReader sdr=null;
			using(sdr=SqlDBHelp.GetReader("select * from Files where author_id="+t_author_id))
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
			SqlParameter[] p=new SqlParameter[]{
				new SqlParameter("@Id",t_File.Id),					
				new SqlParameter("@Filename",t_File.Filename),					
				new SqlParameter("@Mime",t_File.Mime),					
				new SqlParameter("@Filecontent",t_File.Filecontent),					
				new SqlParameter("@Author_id",t_File.Author_id)				
				
			};
			
			int i=SqlDBHelp.GetExecute("insert into Files values(@Id,@Filename,@Mime,@Filecontent,@Author_id)",p);
			return i;				
		}
		
		public  int UpdateFile(FileEntity t_File)
		{
			SqlParameter[] p=new SqlParameter[]{
				new SqlParameter("@Id",t_File.Id),					
				new SqlParameter("@Filename",t_File.Filename),					
				new SqlParameter("@Mime",t_File.Mime),					
				new SqlParameter("@Filecontent",t_File.Filecontent),					
				new SqlParameter("@Author_id",t_File.Author_id)				
				
			};
			
			int i=SqlDBHelp.GetExecute("update Files set filename=@Filename,mime=@Mime,filecontent=@Filecontent,author_id=@Author_id where id=@Id",p);
			return i;	
		}
		
		public  int DeleteFile(int t_id)
		{
			int i=SqlDBHelp.GetExecute("delete from Files where id="+t_id);
			return i;
		}
	}
}


