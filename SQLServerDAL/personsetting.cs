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
	//Personsetting
	///
	public class Personsetting:IPersonsetting
	{
		public  PersonsettingEntity SelectPersonsettingByID(int t_id)
		{
			PersonsettingEntity t_Personsetting=new PersonsettingEntity();
			SqlDataReader sdr =null;
			using(sdr=SqlDBHelp.GetReader("select * from Personsettings where id="+t_id))
			{
				if(sdr.Read())
				{
					t_Personsetting.Id=(int)sdr.GetValue(0);
					t_Personsetting.Author_id=(int)sdr.GetValue(1);
					t_Personsetting.Blog_title=(string)sdr.GetValue(2);
					t_Personsetting.Model_id=(int)sdr.GetValue(3);
					t_Personsetting.Description=(string)sdr.GetValue(4);
					t_Personsetting.Blog_path=(string)sdr.GetValue(5);
					t_Personsetting.Rss_size=(int)sdr.GetValue(6);
					t_Personsetting.Max_uploadfile=(int)sdr.GetValue(7);
					
				}
				
			}
			sdr.Close();
			
			return t_Personsetting;
		}
		
		public IList<PersonsettingEntity> GetAllPersonsetting()
		{
			IList<PersonsettingEntity> t_Personsettings=new List<PersonsettingEntity>();
			SqlDataReader sdr=null;
			using(sdr=SqlDBHelp.GetReader("select * from Personsettings"))
			{
				while(sdr.Read())
				{
					PersonsettingEntity t_Personsetting=new PersonsettingEntity();
					t_Personsetting.Id=(int)sdr.GetValue(0);					
					t_Personsetting.Author_id=(int)sdr.GetValue(1);					
					t_Personsetting.Blog_title=(string)sdr.GetValue(2);					
					t_Personsetting.Model_id=(int)sdr.GetValue(3);					
					t_Personsetting.Description=(string)sdr.GetValue(4);					
					t_Personsetting.Blog_path=(string)sdr.GetValue(5);					
					t_Personsetting.Rss_size=(int)sdr.GetValue(6);					
					t_Personsetting.Max_uploadfile=(int)sdr.GetValue(7);					
					t_Personsettings.Add(t_Personsetting);
				}
				sdr.Close();
			}
			
			return t_Personsettings;
		}
		
		
		public IList<PersonsettingEntity> GetAllPersonsettingByauthor_id(int t_author_id)
		{
			IList<PersonsettingEntity> t_Personsettings=new List<PersonsettingEntity>();
			SqlDataReader sdr=null;
			using(sdr=SqlDBHelp.GetReader("select * from Personsettings where author_id="+t_author_id))
			{
				while(sdr.Read())
				{
					PersonsettingEntity t_Personsetting=new PersonsettingEntity();
					t_Personsetting.Id=(int)sdr.GetValue(0);
					t_Personsetting.Author_id=(int)sdr.GetValue(1);
					t_Personsetting.Blog_title=(string)sdr.GetValue(2);
					t_Personsetting.Model_id=(int)sdr.GetValue(3);
					t_Personsetting.Description=(string)sdr.GetValue(4);
					t_Personsetting.Blog_path=(string)sdr.GetValue(5);
					t_Personsetting.Rss_size=(int)sdr.GetValue(6);
					t_Personsetting.Max_uploadfile=(int)sdr.GetValue(7);
					t_Personsettings.Add(t_Personsetting);
				}
				sdr.Close();
			}
			
			return t_Personsettings;
		}
		
		public IList<PersonsettingEntity> GetAllPersonsettingBymodel_id(int t_model_id)
		{
			IList<PersonsettingEntity> t_Personsettings=new List<PersonsettingEntity>();
			SqlDataReader sdr=null;
			using(sdr=SqlDBHelp.GetReader("select * from Personsettings where model_id="+t_model_id))
			{
				while(sdr.Read())
				{
					PersonsettingEntity t_Personsetting=new PersonsettingEntity();
					t_Personsetting.Id=(int)sdr.GetValue(0);
					t_Personsetting.Author_id=(int)sdr.GetValue(1);
					t_Personsetting.Blog_title=(string)sdr.GetValue(2);
					t_Personsetting.Model_id=(int)sdr.GetValue(3);
					t_Personsetting.Description=(string)sdr.GetValue(4);
					t_Personsetting.Blog_path=(string)sdr.GetValue(5);
					t_Personsetting.Rss_size=(int)sdr.GetValue(6);
					t_Personsetting.Max_uploadfile=(int)sdr.GetValue(7);
					t_Personsettings.Add(t_Personsetting);
				}
				sdr.Close();
			}
			
			return t_Personsettings;
		}
	
		public  int InsertPersonsetting(PersonsettingEntity t_Personsetting)
		{			
			SqlParameter[] p=new SqlParameter[]{
				new SqlParameter("@Id",t_Personsetting.Id),					
				new SqlParameter("@Author_id",t_Personsetting.Author_id),					
				new SqlParameter("@Blog_title",t_Personsetting.Blog_title),					
				new SqlParameter("@Model_id",t_Personsetting.Model_id),					
				new SqlParameter("@Description",t_Personsetting.Description),					
				new SqlParameter("@Blog_path",t_Personsetting.Blog_path),					
				new SqlParameter("@Rss_size",t_Personsetting.Rss_size),					
				new SqlParameter("@Max_uploadfile",t_Personsetting.Max_uploadfile)				
				
			};
			
			int i=SqlDBHelp.GetExecute("insert into Personsettings values(@Id,@Author_id,@Blog_title,@Model_id,@Description,@Blog_path,@Rss_size,@Max_uploadfile)",p);
			return i;				
		}
		
		public  int UpdatePersonsetting(PersonsettingEntity t_Personsetting)
		{
			SqlParameter[] p=new SqlParameter[]{
				new SqlParameter("@Id",t_Personsetting.Id),					
				new SqlParameter("@Author_id",t_Personsetting.Author_id),					
				new SqlParameter("@Blog_title",t_Personsetting.Blog_title),					
				new SqlParameter("@Model_id",t_Personsetting.Model_id),					
				new SqlParameter("@Description",t_Personsetting.Description),					
				new SqlParameter("@Blog_path",t_Personsetting.Blog_path),					
				new SqlParameter("@Rss_size",t_Personsetting.Rss_size),					
				new SqlParameter("@Max_uploadfile",t_Personsetting.Max_uploadfile)				
				
			};
			
			int i=SqlDBHelp.GetExecute("update Personsettings set author_id=@Author_id,blog_title=@Blog_title,model_id=@Model_id,description=@Description,blog_path=@Blog_path,rss_size=@Rss_size,max_uploadfile=@Max_uploadfile where id=@Id",p);
			return i;	
		}
		
		public  int DeletePersonsetting(int t_id)
		{
			int i=SqlDBHelp.GetExecute("delete from Personsettings where id="+t_id);
			return i;
		}
	}
}


