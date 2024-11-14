using System.Data.SqlClient;

public class XoaMayBay
{
    private string connectionString = "Data Source=HOMHINHHA\\SQLEXPRESS;Initial Catalog=QLMB;Integrated Security=True";

    public void DeleteAircraft(string maMB)
    {
        string query = "DELETE FROM MayBay WHERE MaMB = @MaMB";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaMB", maMB);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
