using System;
using System.Collections.Generic;
using System.Data;
using Project.Core.Entities;

namespace Project.Core.BusinessLayer
{
    public class PersonServices : Helper.Command<Persons>, Interface.ICDIUS<Persons>
    {
        public int Control(Persons t)
        {
            throw new NotImplementedException();
        }
        public int Delete(Persons t)
        {
            TryCatchFinally(() =>
            {
                if (_connDb != null)
                {
                    _connDb._cmd = _connDb.GetSqlCommand("sp_KisiSil");
                    _connDb._cmd.CommandType = CommandType.StoredProcedure;
                    _connDb._cmd.Parameters.Add("@ID", SqlDbType.Int).Value = t.ID;
                    _connDb.obj = _connDb.ExecuteNonQuery(_connDb._cmd);
                    _connDb.GetSqlConnection();
                }
            });
            return _connDb.obj == null ? 0 : (int)_connDb.obj;
        }
        public int Insert(Persons t)
        {
            //delege tanımı yapıldı
            TryCatchFinally(
                 () =>
                 {
                     if (_connDb != null)
                     {
                         _connDb._cmd = _connDb.GetSqlCommand("sp_KisiEkle");
                         _connDb._cmd.CommandType = CommandType.StoredProcedure;
                         _connDb._cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = t.Name;
                         _connDb._cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = t.Surname;
                         _connDb._cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = t.EMail;
                         _connDb._cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = t.Phone;
                         _connDb._cmd.Parameters.Add("@Resim", SqlDbType.VarBinary).Value = t.Photo;
                         _connDb.obj = _connDb.ExecuteNonQuery(_connDb._cmd);
                         _connDb.GetSqlConnection();
                     }
                 });
            return _connDb.obj == null ? 0 : (int)_connDb.obj;
        }
        public Persons Find(int ID)
        {
            _entites = new Persons();
            TryCatchFinally(() =>
            {
                _connDb._cmd = _connDb.GetSqlCommand("select * from tblKisiler where ID=@ID ");
                _connDb._cmd.Parameters.Add("@ID", SqlDbType.Int).Value =ID;
                _connDb._rdr = _connDb._cmd.ExecuteReader();
                while (_connDb._rdr.Read())
                {
                    _entites.ID = _connDb._rdr.IsDBNull(0) ? 0 : _connDb._rdr.GetInt32(0);
                    _entites.Name = _connDb._rdr.IsDBNull(1) ? null : _connDb._rdr.GetString(1);
                    _entites.Surname = _connDb._rdr.IsDBNull(2) ? null : _connDb._rdr.GetString(2);
                    _entites.EMail = _connDb._rdr.IsDBNull(3) ? null : _connDb._rdr.GetString(3);
                    _entites.Phone = _connDb._rdr.IsDBNull(4) ? null : _connDb._rdr.GetString(4);
                    _entites.Photo = _connDb._rdr.IsDBNull(5) ? null : (byte[])_connDb._rdr[5];
                }
                _connDb._rdr.Close();
            });
            return _entites;
        }
        public List<Persons> Select()
        {
            getEntites = new List<Persons>();
            TryCatchFinally(() =>
            {
                _connDb._rdr = _connDb.GetSqlDataReader("select * from tblKisiler");
                while (_connDb._rdr.Read())
                {
                    getEntites.Add(new Persons()
                    {
                        ID = _connDb._rdr.IsDBNull(0) ? 0 : _connDb._rdr.GetInt32(0),
                        Name = _connDb._rdr.IsDBNull(1) ? null : _connDb._rdr.GetString(1),
                        Surname = _connDb._rdr.IsDBNull(2) ? null : _connDb._rdr.GetString(2),
                        EMail = _connDb._rdr.IsDBNull(3) ? null : _connDb._rdr.GetString(3),
                        Phone = _connDb._rdr.IsDBNull(4) ? null : _connDb._rdr.GetString(4),
                        Photo = _connDb._rdr.IsDBNull(5) ? null : (byte[])_connDb._rdr[5],
                    });
                }
                _connDb._rdr.Close();
            });
            return getEntites;
        }
        public int Update(Persons t)
        {
            if (_connDb != null)
            {
                _connDb._cmd = _connDb.GetSqlCommand("sp_KisiGüncelle");
                _connDb._cmd.CommandType = CommandType.StoredProcedure;
                _connDb._cmd.Parameters.Add("@ID", SqlDbType.Int).Value = t.ID;
                _connDb._cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = t.Name;
                _connDb._cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = t.Surname;
                _connDb._cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = t.EMail;
                _connDb._cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = t.Phone;
                _connDb._cmd.Parameters.Add("@Resim", SqlDbType.VarBinary).Value = t.Photo;
                _connDb.obj = _connDb.ExecuteNonQuery(_connDb._cmd);
                _connDb.GetSqlConnection();
            }
            return _connDb.obj == null ? 0 : (int)_connDb.obj;
        }
        public Persons Find(Guid ID)
        {
            throw new NotImplementedException();
        }
    }
}
