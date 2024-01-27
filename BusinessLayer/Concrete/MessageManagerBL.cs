using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManagerBL : IMessageServiceBL
    {
        IMessageDAL _messageDal;

        public MessageManagerBL(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

		public Message GetByID(int id)
		{
			return _messageDal.Get(x => x.MessageID == id);
		}

		public List<Message> GetListInbox(string p)
		{
			return _messageDal.List(x => x.ReceiverMail == p);
		}

		public List<Message> GetListInbox(bool messageStatus, string userMail)
		{
			return _messageDal.List(x => x.MessageStatus == messageStatus && x.ReceiverMail == userMail);
		}

		public List<Message> GetListSendbox(string p)
		{
			return _messageDal.List(x => x.SenderMail == p);
		}

		public void MessageAdd(Message message)
		{
			_messageDal.Insert(message);
		}

		public void MessageDelete(Message message)
		{
			throw new NotImplementedException();
		}

		public void MessageUpdate(Message message)
		{
			_messageDal.Update(message);
		}

		//public Message GetByID(int id)
		//{
		//    return _messageDal.Get(x => x.MessageID == id);
		//}

		//public List<Message> GetListInbox(string p)
		//{
		//    return _messageDal.List(x => x.ReceiverMail == p);
		//}

		//public List<Message> GetListSendbox(string p)
		//{
		//    return _messageDal.List(x => x.SenderMail == p);
		//}

		//public void MessageAdd(Message message)
		//{
		//    _messageDal.Insert(message);
		//}

		//public void MessageDelete(Message message)
		//{
		//    _messageDal.Delete(message);
		//}

		//public void MessageUpdate(Message message)
		//{
		//    _messageDal.Update(message);
		//}
	}
}
