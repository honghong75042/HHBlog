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
	//Author
	///
	public class Author:IAuthor
	{
		public  AuthorEntity SelectAuthorByID(int t_author_id)
		{
			AuthorEntity t_Author=new AuthorEntity();
			OleDbDataReader sdr =null;
			using(sdr=OLEDBHelp.GetReader("select * from Author where author_id="+t_author_id))
			{
				if(sdr.Read())
				{
					t_Author.Author_id=(int)sdr.GetValue(0);
					t_Author.Username=(string)sdr.GetValue(1);
					t_Author.Password=(string)sdr.GetValue(2);
					t_Author.Role_id=(int)sdr.GetValue(3);
					t_Author.Islock=(string)sdr.GetValue(4);
					
				}
				
			}
			sdr.Close();
			
			return t_Author;
		}
		
		public IList<AuthorEntity> GetAllAuthor()
		{
			IList<AuthorEntity> t_Authors=new List<AuthorEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Author"))
			{
				while(sdr.Read())
				{
					AuthorEntity t_Author=new AuthorEntity();
					t_Author.Author_id=(int)sdr.GetValue(0);					
					t_Author.Username=(string)sdr.GetValue(1);					
					t_Author.Password=(string)sdr.GetValue(2);					
					t_Author.Role_id=(int)sdr.GetValue(3);					
					t_Author.Islock=(string)sdr.GetValue(4);					
					t_Authors.Add(t_Author);
				}
				sdr.Close();
			}
			
			return t_Authors;
		}
		
		
		public IList<AuthorEntity> GetAllAuthorByrole_id(int t_role_id)
		{
			IList<AuthorEntity> t_Authors=new List<AuthorEntity>();
			OleDbDataReader sdr=null;
			using(sdr=OLEDBHelp.GetReader("select * from Author where role_id="+t_role_id))
			{
				while(sdr.Read())
				{
					AuthorEntity t_Author=new AuthorEntity();
					t_Author.Author_id=(int)sdr.GetValue(0);
					t_Author.Username=(string)sdr.GetValue(1);
					t_Author.Password=(string)sdr.GetValue(2);
					t_Author.Role_id=(int)sdr.GetValue(3);
					t_Author.Islock=(string)sdr.GetValue(4);
					t_Authors.Add(t_Author);
				}
				sdr.Close();
			}
			
			return t_Authors;
		}
	
		public  int InsertAuthor(AuthorEntity t_Author)
		{			
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Author_id",t_Author.Author_id),					
				new OleDbParameter("@Username",t_Author.Username),					
				new OleDbParameter("@Password",t_Author.Password),					
				new OleDbParameter("@Role_id",t_Author.Role_id),					
				new OleDbParameter("@Islock",t_Author.Islock)				
				
			};
			
			int i=OLEDBHelp.GetExecute("insert into Author values(@Author_id,@Username,@Password,@Role_id,@Islock)",p);
			return i;				
		}
		
		public  int UpdateAuthor(AuthorEntity t_Author)
		{
			OleDbParameter[] p=new OleDbParameter[]{
				new OleDbParameter("@Author_id",t_Author.Author_id),					
				new OleDbParameter("@Username",t_Author.Username),					
				new OleDbParameter("@Password",t_Author.Password),					
				new OleDbParameter("@Role_id",t_Author.Role_id),					
				new OleDbParameter("@Islock",t_Author.Islock)				
				
			};
			
			int i=OLEDBHelp.GetExecute("update Author set username=@Username,password=@Password,role_id=@Role_id,islock=@Islock where author_id=@Author_id",p);
			return i;	
		}
		
		public  int DeleteAuthor(int t_author_id)
		{
			int i=OLEDBHelp.GetExecute("delete from Author where author_id="+t_author_id);
			return i;
		}
	}
}


