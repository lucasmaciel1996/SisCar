﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using Npgsql;

namespace DAL
{
    public class PerfilDAL
    {
        public void SalvarImagem(Perfil perfil){

        try{
            String salvarI = (String.Format(
                "UPDATE USUARIOS_CONFIG " +
                "SET VALOR = '{0}', " +
                "PLANO_DE_FUNDO = '{1}' " +
                "WHERE LOGIN = '{2}' ", perfil.Imagem, 'I', perfil.Login));

            NpgsqlCommand comandoUpdate = new NpgsqlCommand(salvarI, ConnectionFactory.Connect());
            comandoUpdate.ExecuteNonQuery();


         }catch(Exception ex){
           throw new Exception("Falha ao Salvar o caminho da Image!" + ex.Message); 

         }
        finally{
            ConnectionFactory.Connect().Close();
          }
      }

        public void SalvarCor(Perfil perfil)
        {

            try
            {
                String salvarC = (String.Format(
                    "UPDATE USUARIOS_CONFIG " +
                    "SET VALOR = '{0}', " +
                    "PLANO_DE_FUNDO = '{1}' " +
                    "WHERE LOGIN = '{2}' ", perfil.Cor, 'C', perfil.Login));

                NpgsqlCommand comandoUpdate = new NpgsqlCommand(salvarC, ConnectionFactory.Connect());
                comandoUpdate.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao atualizar a Cor!" + ex.Message);

            }
            finally
            {
                ConnectionFactory.Connect().Close();
            }
        }


        public String VerificarCoreFundo(Perfil perfil)
        {

                    try
                    {
                        String Verifica = (String.Format(
                            "SELECT PLANO_DE_FUNDO " +
                            "FROM USUARIOS_CONFIG " +
                            "WHERE LOGIN = '{0}' ", perfil.Login));

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(Verifica, ConnectionFactory.Connect());
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            return dt.Rows[0]["plano_de_fundo"].ToString();
                        }
                        else
                        {
                            return null;
                        }


                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Falha ao Verificar o campo na base dados!" + ex.Message);

                    }
                    finally
                    {
                        ConnectionFactory.Connect().Close();
                    }
          }

            public String RetornaCorFundo(Perfil perfil )
            {
                 try{
                     String retorna = (String.Format(
                         "SELECT VALOR " +
                         "FROM USUARIOS_CONFIG " +
                         "WHERE LOGIN = '{0}' " +perfil.Login));

                     NpgsqlDataAdapter da = new NpgsqlDataAdapter
                         (new NpgsqlCommand(retorna,ConnectionFactory.Connect()));
                     DataTable dt = new DataTable();
                     da.Fill(dt);

                     if(dt.Rows.Count > 0){

                        return dt.Rows[0]["valor"].ToString();

                     }
                     else
                     {
                     return null;
                     }


                 }catch(Exception ex)
                 {
                     throw new Exception("Falha ao retorna valor do campo!"+ ex.Message);
                 }
                 finally
                 {
                 ConnectionFactory.Connect().Close();
                 }
            }
        }
}


