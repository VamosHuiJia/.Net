using System.Data.SqlClient;

public class ThemMayBay
{
    private string connectionString = "Data Source=HOMHINHHA\\SQLEXPRESS;Initial Catalog=QLMB;Integrated Security=True";

    public void AddAircraft(string maMB, string tenMayBay, int namSX, int soGioBay)
    {
        string query = "INSERT INTO MayBay (MaMB, TenMayBay, NamSX, SoGioBay) VALUES (@MaMB, @TenMayBay, @NamSX, @SoGioBay)";

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
