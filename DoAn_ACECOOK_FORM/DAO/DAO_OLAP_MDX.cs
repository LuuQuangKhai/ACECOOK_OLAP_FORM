using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AnalysisServices;
using Microsoft.AnalysisServices.AdomdClient;

namespace DAO
{
    public class DAO_OLAP_MDX
    {
        private string _connectionString = @"Provider=MSOLAP;Data Source=LUUQUANGKHAI\KHAISERVER;Initial Catalog=SSAS_ACECOOK_2;Integrated Security=SSPI";

        public DataTable ExecuteMDXQuery(string mdxQuery)
        {
            try
            {
                using (var connection = new AdomdConnection(_connectionString))
                {
                    connection.Open();
                    var query = new AdomdCommand(mdxQuery, connection);
                    var result = query.ExecuteReader();

                    var dataTable = new DataTable();
                    var schemaTable = result.GetSchemaTable();
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        dataTable.Columns.Add((string)row["ColumnName"]);
                    }

                    while (result.Read())
                    {
                        object[] values = new object[result.FieldCount];
                        result.GetValues(values);
                        dataTable.Rows.Add(values);
                    }

                    return dataTable;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
