
///
//generate by CodeSmith
//created time:2010?1?24?
//Name:NN
///

using System;

namespace Blogo.Model
{
	public class LogEntity
	{
		protected int _id;
		protected int _author_id;
		protected DateTime _date;
		protected string _opevent = String.Empty;
	
		public LogEntity()
		{
			
		}
		
		public LogEntity(int id,int author_id,DateTime date,string opevent)
		{
			_id = id ;	
			_author_id = author_id ;	
			_date = date ;	
			_opevent = opevent ;	
		}
		
		public int  Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id=value;
			}				
		}
			
		public int  Author_id
		{
			get
			{
				return _author_id;
			}
			set
			{
				_author_id=value;
			}				
		}
			
		public DateTime  Date
		{
			get
			{
				return _date;
			}
			set
			{
				_date=value;
			}				
		}
			
		public string  Opevent
		{
			get
			{
				return _opevent;
			}
			set
			{
				_opevent=value;
			}				
		}
			
	}
}


