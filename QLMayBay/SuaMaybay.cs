using System.Data.SqlClient;

public class SuaMayBay
{
    private string connectionString = "Data Source=HOMHINHHA\\SQLEXPRESS;Initial Catalog=QLMB;Integrated Security=True";

    public void UpdateAircraft(string maMB, string tenMayBay, int namSX, int soGioBay)
    {
        string query = "UPDATE MayBay SET TenMayBay = @TenMayBay, NamSX = @NamSX, SoGioBay = @SoGioBay WHERE MaMB = @MaMB";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaMB", maMB);
            cmd.Parameters.AddWithValue("@TenMayBay", tenMayBay);
            cmd.Parameters.AddWithValue("@NamSX", namSX);
            cmd.Parameters.AddWithValue("@SoGioBay", soGioBay);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}