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
	//Role
	///
	public class Role:IRole
	{
		public  RoleEntity SelectRoleByID(int t_role_id)
		{
			RoleEntity t_Role=new RoleEntity();
			SqlDataReader sdr =null;
			using(sdr=SqlDBHelp.GetReader("select * from Role where role_id="+t_role_id))
			{
				if(sdr.Read())
				{
					t_Role.Role_id=(int)sdr.GetValue(0);
					t_Role.Name=(string)sdr.GetValue(1);
					
				}
				
			}
			sdr.Close();
			
			return t_Role;
		}
		
		public IList<RoleEntity> GetAllRole()
		{
			IList<RoleEntity> t_Roles=new List<RoleEntity>();
			SqlDataReader sdr=null;
			using(sdr=SqlDBHelp.GetReader("select * from Role"))
			{
				while(sdr.Read())
				{
					RoleEntity t_Role=new RoleEntity();
					t_Role.Role_id=(int)sdr.GetValue(0);					
					t_Role.Name=(string)sdr.GetValue(1);					
					t_Roles.Add(t_Role);
				}
				sdr.Close();
			}
			
			return t_Roles;
		}
		
	
		public  int InsertRole(RoleEntity t_Role)
		{			
			SqlParameter[] p=new SqlParameter[]{
				new SqlParameter("@Role_id",t_Role.Role_id),					
				new SqlParameter("@Name",t_Role.Name)				
				
			};
			
			int i=SqlDBHelp.GetExecute("insert into Role values(@Role_id,@Name)",p);
			return i;				
		}
		
		public  int UpdateRole(RoleEntity t_Role)
		{
			SqlParameter[] p=new SqlParameter[]{
				new SqlParameter("@Role_id",t_Role.Role_id),					
				new SqlParameter("@Name",t_Role.Name)				
				
			};
			
			int i=SqlDBHelp.GetExecute("update Role set name=@Name where role_id=@Role_id",p);
			return i;	
		}
		
		public  int DeleteRole(int t_role_id)
		{
			int i=SqlDBHelp.GetExecute("delete from Role where role_id="+t_role_id);
			return i;
		}
	}
}


