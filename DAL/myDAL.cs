using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace FrontEnd_NayaPakistan.DAL
{
    public class myDAL
    {
        private static readonly string connString = System.Configuration.ConfigurationManager.ConnectionStrings["db1"].ConnectionString;

        public DataSet displayAllDoctors()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select (first_name+' '+last_name) as Name, phoneNumber as Phone, email as Email, Dep.name as Department, sp.name as Specialization from doctor as Doc inner join department as Dep on Dep.id = Doc.department inner join specialization as sp on Doc.specialization_id = sp.id", con)
                {
                    CommandType = CommandType.Text
                };
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }     

        public int getDoctorID(string username, string password)
        {
            int docID = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("loginDoctor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@docID", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.ExecuteNonQuery();

                //read output value
                docID = Convert.ToInt32(cmd.Parameters["@docID"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return docID;

        }

        public int getPatientID(string username, string password)
        {
            int patientID = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("loginPatient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@patientID", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.ExecuteNonQuery();

                //read output value
                patientID = Convert.ToInt32(cmd.Parameters["@patientID"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return patientID;
        }
        public int getnurseID(string username, string password)
        {
            int nurseID = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("loginNurse", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@nurseID", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.ExecuteNonQuery();

                //read output value
                nurseID = Convert.ToInt32(cmd.Parameters["@nurseID"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return nurseID;

        }
        public int getStaffID(string username, string password)
        {
            int staffID = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("loginStaff", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@staffID", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.ExecuteNonQuery();

                //read output value
                staffID = Convert.ToInt32(cmd.Parameters["@staffID"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return staffID;

        }
        public int getAdminID(string username, string password)
        {
            int adminID = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("loginAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 36);
                cmd.Parameters.Add("@adminID", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.ExecuteNonQuery();

                //read output value
                adminID = Convert.ToInt32(cmd.Parameters["@adminID"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return adminID;

        }

        public DataSet getDoctorDetailsFromID(int docID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select D.id as [Doctor ID], D.first_name as [First Name], D.last_name as [Last Name], L.username as Username ,D.email, D.phoneNumber as Contact ,D.salary as Salary, D.gender as Gender,dep.name as Department, S.name as Specialization, D.rating as [Total Rating] from doctor as D inner join specialization as S on D.specialization_id = S.id inner join login as L on D.loginID = L.id inner join department as dep on dep.id = D.department where D.id = @doctorID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@doctorID", SqlDbType.Int);
                cmd.Parameters["@doctorID"].Value = docID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getNurseDetailsFromID(int nurseID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select D.id as [Nurse ID], D.first_name as [First Name], D.last_name as [Last Name], L.username as Username ,D.email, D.phoneNumber as Contact, D.salary as Salary ,D.gender as Gender,dep.name as Department, S.name as Specialization from Nurse as D inner join specialization as S on D.specialization_id = S.id inner join login as L on D.loginID = L.id inner join department as dep on dep.id = D.department where D.id = @nurseID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@nurseID", SqlDbType.Int);
                cmd.Parameters["@nurseID"].Value = nurseID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getPatientDetailsFromID(int patientID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select D.id as [Patient ID], D.first_name as [First Name], D.last_name as [Last Name], L.username as Username ,D.email, D.phoneNumber as Contact from patient as D inner join login as L on D.loginID = L.id where D.id = @patientID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@patientID", SqlDbType.Int);
                cmd.Parameters["@patientID"].Value = patientID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getStaffDetailsFromID(int staffID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select D.id as [Staff ID], D.first_name as [First Name], D.last_name as [Last Name], L.username as Username ,D.email, D.phoneNumber as Contact, salary as Salary from staff as D inner join login as L on D.loginID = L.id where D.id = @staffID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@staffID", SqlDbType.Int);
                cmd.Parameters["@staffID"].Value = staffID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getAdminDetailsFromID(int adminID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select D.id as [Staff ID], D.first_name as [First Name], D.last_name as [Last Name], L.username as Username ,D.email, D.phoneNumber as Contact, salary as Salary from admin as D inner join login as L on D.loginID = L.id where D.id = @adminID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@adminID", SqlDbType.Int);
                cmd.Parameters["@adminID"].Value = adminID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        public DataSet getAppFromDocId(int id)
        {
            DataSet ds = new DataSet();
            int docID = id;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("DoctorHistory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@DoctorId", SqlDbType.Int);      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@DoctorId"].Value = docID;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }

                //read output value
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }
        public DataSet getAppTestFromPatientId(int id)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("PatientHistory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@patientId", SqlDbType.Int);      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@patientId"].Value = id;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }

                //read output value
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }
        public void requestDataChange(string tableName, string attributeName, int tableID, int toChangeNum, string toChangeStr)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("profileEditRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@tableName", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@attName", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@toChangeInt", SqlDbType.Int);
                cmd.Parameters.Add("@toChangeVar", SqlDbType.VarChar, 20);

                //setting input parameters value
                cmd.Parameters["@tableName"].Value = tableName;
                cmd.Parameters["@attName"].Value = attributeName;
                cmd.Parameters["@id"].Value = tableID;
                cmd.Parameters["@toChangeInt"].Value = toChangeNum;
                cmd.Parameters["@toChangeVar"].Value = toChangeStr;

                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

        public DataSet getLabsName()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select id, name from lab", con);
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getTestsfromLabsName()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select distinct id, name from test", con);
                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }
        public DataSet getPatientsfromDocID(int doctorID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select id as [ID], first_name as [First Name], last_name as [Last Name], email as [Email], phoneNumber as [Phone Number] from patient where id in (select distinct patientID from appointment where doctorID = @docID)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@docID", SqlDbType.Int);
                cmd.Parameters["@docID"].Value = doctorID;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;

        }
        public int bookLabForPatient(int labID, int testID, int patientID, string time, string date)
        {
            int retVal = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("bookLabs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@lab", SqlDbType.Int);
                cmd.Parameters.Add("@test", SqlDbType.Int);
                cmd.Parameters.Add("@patientID", SqlDbType.Int);
                cmd.Parameters.Add("@bookingDateTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@lab"].Value=labID;
                cmd.Parameters["@test"].Value=testID;
                cmd.Parameters["@patientID"].Value=patientID;
                string str = date + ' ' + time;
                cmd.Parameters["@bookingDateTime"].Value = DateTime.Parse(str);
                cmd.ExecuteNonQuery();

                //read output value
                retVal = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return retVal;
        }

        public DataSet getMemberships()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select id,name from membershipType", con);
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public string getMembershipOfPatient(int patientID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            string retVal=string.Empty;
            try
            {
                cmd = new SqlCommand("currentMembership", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@pid", SqlDbType.Int);
                cmd.Parameters.Add("@output", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output;

                //setting input parameters value
                cmd.Parameters["@pid"].Value = patientID;
                cmd.ExecuteNonQuery();
                //read output value

                retVal = Convert.ToString(cmd.Parameters["@output"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return retVal;

        }
        public int buyMembership(int patientID, int membershipID)
        {
            int retVal = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("buyMembership", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@patientID", SqlDbType.Int);
                cmd.Parameters.Add("@membershipid", SqlDbType.Int);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@patientID"].Value = patientID;
                cmd.Parameters["@membershipid"].Value = membershipID; 
                cmd.ExecuteNonQuery();

                //read output value
                retVal = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return retVal;
        }

        public DataSet getTreatmentTypes()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select id, name from treatmentType", con);
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getDocsWithID()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select D.id as [ID], first_name as [First Name], last_name as [Last Name], S.name as Specialization, Dep.name as Department from doctor D inner join specialization S on D.specialization_id=S.id inner join department Dep on D.department=Dep.id", con);
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public int bookAppForPatient(int patientID, int doctorID, int treatmentID, string time, string date)
        {
            int retVal = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                /*@doctorId int,
                @patientID int,
                @treatmentType int,
                @bookingDateTime datetime,
	            @status int output*/
                cmd = new SqlCommand("bookAppointment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@doctorId", SqlDbType.Int);
                cmd.Parameters.Add("@patientID", SqlDbType.Int);
                cmd.Parameters.Add("@treatmentType", SqlDbType.Int);
                cmd.Parameters.Add("@bookingDateTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@doctorId"].Value = doctorID;
                cmd.Parameters["@patientID"].Value = patientID;
                cmd.Parameters["@treatmentType"].Value = treatmentID;
                string str = date + ' ' + time;
                cmd.Parameters["@bookingDateTime"].Value = DateTime.Parse(str);
                cmd.ExecuteNonQuery();

                //read output value
                retVal = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return retVal;
        }
       
        public DataSet getpastApp(int patientID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("PatientPastAppointments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@patientId", SqlDbType.Int);

                //setting input parameters value
                cmd.Parameters["@patientId"].Value = patientID;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }

                //read output value
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public void givereview(int appID, int docRating, int staffRating, string comments)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("giveReview", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@appintmentID", SqlDbType.Int);
                cmd.Parameters.Add("@doctorRating", SqlDbType.Int);
                cmd.Parameters.Add("@staffRating", SqlDbType.Int);
                cmd.Parameters.Add("@comments", SqlDbType.VarChar, 200);

                //setting input parameters value
                cmd.Parameters["@appintmentID"].Value=appID;
                cmd.Parameters["@doctorRating"].Value=docRating;
                cmd.Parameters["@staffRating"].Value = staffRating;
                cmd.Parameters["@comments"].Value = comments;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet getmedicinesList()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select sku as SKU, price*1.15 as [Price/Unit], name as Name, saltFormula as [Salt Formula], quantity as Quantity from medicine_stock", con)
                {
                    CommandType = CommandType.Text
                };
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public int buyMedicine(int patientID, int medSKU, int medQuantity)
        {
            int retVal = 0;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("buyMedicine", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@patient", SqlDbType.Int);
                cmd.Parameters.Add("@medicine", SqlDbType.Int);
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;      //this one is output parameter

                //setting input parameters value
                cmd.Parameters["@patient"].Value = patientID;
                cmd.Parameters["@medicine"].Value = medSKU;
                cmd.Parameters["@quantity"].Value = medQuantity;
                cmd.ExecuteNonQuery();

                //read output value
                retVal = Convert.ToInt32(cmd.Parameters["@status"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return retVal;
        }


        public DataSet getUnpaidItems(int patientId, ref int totalAmount)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("pendingPayments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@patientId", SqlDbType.Int);
                cmd.Parameters.Add("@totalPayment",SqlDbType.Int).Direction= ParameterDirection.Output;

                //setting input parameters value
                cmd.Parameters["@patientId"].Value = patientId;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }

                //read output value
                totalAmount = Convert.ToInt32(cmd.Parameters["@totalPayment"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public void payUnpaidItems(int patientId)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("payPendingPayments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //creatig parameters
                cmd.Parameters.Add("@patientId", SqlDbType.Int);

                //setting input parameters value
                cmd.Parameters["@patientId"].Value = patientId;

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet getFreeRooms()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd1, cmd2;
            try
            {
                cmd1 = new SqlCommand("update room set patient=null,dateOfDischarge=null,timeOfDischarge=null where dateOfDischarge < CONVERT(date,GETDATE()) or (dateOfDischarge = CONVERT(date,GETDATE()) and timeOfDischarge < CONVERT(time,GETDATE()))", con)
                {
                    CommandType = CommandType.Text
                };
                cmd1.ExecuteNonQuery();

                cmd2 = new SqlCommand("select room.id as ID, roomType.description as [Room Type], roomType.price as Price from room inner join roomType on room.typeID=roomType.id where room.patient is null", con)
                {
                    CommandType = CommandType.Text
                };
                using (SqlDataAdapter da = new SqlDataAdapter(cmd2))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public void bookRoom(int roomId, int patientId, string insertionTime, string insertionDate)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("update room set patient=@patient, dateOfDischarge=CONVERT(date,@insertionDateTime), timeOfDischarge=CONVERT(time,@insertionDateTime) where id=@roomsID", con)
                {
                    CommandType = CommandType.Text
                };

                //creatig parameters

                cmd.Parameters.Add("@patient", SqlDbType.Int);
                cmd.Parameters.Add("@insertionDateTime", SqlDbType.DateTime);
                cmd.Parameters.Add("@roomsID", SqlDbType.Int);

                //setting input parameters value
                cmd.Parameters["@patient"].Value = patientId;
                cmd.Parameters["@insertionDateTime"].Value = DateTime.Parse(insertionDate + ' ' + insertionTime); ;
                cmd.Parameters["@roomsID"].Value = roomId;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        ///////////////

        public DataSet getRequests(int adminID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select * from profileEdit", con);
                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public void sendApproveRequest(int id)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("processEditRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);

                cmd.Parameters.Add("@status", SqlDbType.Int);

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@status"].Value = 1;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        public void sendDisapproveRequest(int id)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("processEditRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int);

                cmd.Parameters.Add("@status", SqlDbType.Int);

                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@status"].Value = 0;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }


        public void signUpDoctor(string first_name, string last_name, string email, string phone_number, string gender, string salary, string specilization, string username, string password, string dept)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signUpDoctor", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.Char);
                cmd.Parameters.Add("@salary", SqlDbType.Int);
                cmd.Parameters.Add("@specialization", SqlDbType.VarChar);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@department", SqlDbType.VarChar);

                cmd.Parameters["@first_name"].Value = first_name;
                cmd.Parameters["@last_name"].Value = last_name;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phoneNumber"].Value = phone_number;
                cmd.Parameters["@gender"].Value = gender;
                cmd.Parameters["@salary"].Value = int.Parse(salary);
                cmd.Parameters["@specialization"].Value = specilization;
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters["@department"].Value = dept;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void signUpNurse(string first_name, string last_name, string email, string phone_number, string gender, string salary, string specilization, string username, string password, string dept)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signUpNurse", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.Char);
                cmd.Parameters.Add("@salary", SqlDbType.Int);
                cmd.Parameters.Add("@specialization", SqlDbType.VarChar);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@department", SqlDbType.VarChar);

                cmd.Parameters["@first_name"].Value = first_name;
                cmd.Parameters["@last_name"].Value = last_name;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phoneNumber"].Value = phone_number;
                cmd.Parameters["@gender"].Value = gender;
                cmd.Parameters["@salary"].Value = int.Parse(salary);
                cmd.Parameters["@specialization"].Value = specilization;
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters["@department"].Value = dept;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void signUpStaff(string first_name, string last_name, string email, string phone_number, string gender, string salary, string username, string password)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signUpStaff", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.Char);
                cmd.Parameters.Add("@salary", SqlDbType.Int);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);

                cmd.Parameters["@first_name"].Value = first_name;
                cmd.Parameters["@last_name"].Value = last_name;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phoneNumber"].Value = phone_number;
                cmd.Parameters["@gender"].Value = gender;
                cmd.Parameters["@salary"].Value = int.Parse(salary);
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void signUpAdmin(string first_name, string last_name, string email, string phone_number, string gender, string salary, string username, string password)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signUpAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.Char);
                cmd.Parameters.Add("@salary", SqlDbType.Int);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);

                cmd.Parameters["@first_name"].Value = first_name;
                cmd.Parameters["@last_name"].Value = last_name;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phoneNumber"].Value = phone_number;
                cmd.Parameters["@gender"].Value = gender;
                cmd.Parameters["@salary"].Value = int.Parse(salary);
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void signUpPatient(string first_name, string last_name, string email, string phone_number, string gender, string username, string password, string dept)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signUpPatient", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
                cmd.Parameters.Add("@gender", SqlDbType.Char);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@department", SqlDbType.VarChar);

                cmd.Parameters["@first_name"].Value = first_name;
                cmd.Parameters["@last_name"].Value = last_name;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@phoneNumber"].Value = phone_number;
                cmd.Parameters["@gender"].Value = gender;
                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters["@department"].Value = dept;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        public DataSet getIncomingExpenses(int adminID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Incoming_Expenses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sumtotal", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataSet getOutgoingExpenses(int adminID)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Outgoing_Expenses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sumtotal", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

    }
}


