using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractWork
{
    public class TablesRep
    {
        SQLiteConnection database;

        public TablesRep(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<ContractStatus>();
            database.CreateTable<TypeOfContract>();
            database.CreateTable<Contract>();
        }
		// Методы для таблицы Типы договоров
		public IEnumerable<TypeOfContract> GetItemsType()
		{
			return database.Table<TypeOfContract>().ToList();
		}
		public TypeOfContract GetItemType(int id)
		{
			return database.Get<TypeOfContract>(id);
		}
		public int DeleteItemType(int id)
		{
			return database.Delete<TypeOfContract>(id);
		}
		public int SaveItemType(TypeOfContract item)
		{
			if (item.Id != 0)
			{
				database.Update(item);
				return item.Id;
			}
			else
			{
				return database.Insert(item);
			}
		}

		// Методы для таблицы Статусы договоров
		public IEnumerable<ContractStatus> GetItemsStatus()
		{
			return database.Table<ContractStatus>().ToList();
		}
		public ContractStatus GetItemStatus(int id)
		{
			return database.Get<ContractStatus>(id);
		}
		public int DeleteItemStatus(int id)
		{
			return database.Delete<ContractStatus>(id);
		}
		public int SaveItemStatus(ContractStatus item)
		{
			if (item.Id != 0)
			{
				database.Update(item);
				return item.Id;
			}
			else
			{
				return database.Insert(item);
			}
		}

		// Методы для таблицы Договоры
		public IEnumerable<Contract> GetItemsContract()
		{
			return database.Table<Contract>().ToList();
		}
		public Contract GetItemContract(int id)
		{
			return database.Get<Contract>(id);
		}
		public int DeleteItemContract(int id)
		{
			return database.Delete<Contract>(id);
		}
		public int SaveItemContract(Contract item)
		{
			if (item.Code != 0)
			{
				database.Update(item);
				return item.Code;
			}
			else
			{
				return database.Insert(item);
			}
		}
	}
}
