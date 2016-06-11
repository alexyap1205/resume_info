using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessor : IDataAccessor
    {
        private SqlConnection connection;

        public void Initialize()
        {
            connection = CreateConnection();
        }

        public void UnInitialize()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception)
                {
                    // DO NOTHING
                }
                finally
                {
                    connection = null;
                }
            }
        }

        public ProfileInformation GetDefaultProfile()
        {
            ProfileInformation information = null;

            if (connection != null)
            {
                string sql = @"SELECT ProfileID, ProfileName, DisplayName FROM ProfileInformation WHERE ProfileID=5";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    information = new ProfileInformation()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        DisplayName = reader.GetString(2)
                    };

                }

                reader.Close();
                command.Dispose();
            }

            return information;
        }

        public ContactInformation GetContactInformation()
        {
            ContactInformation information = null;

            if (connection != null)
            {
                string sql = @"SELECT Address, Mobile FROM ProfileInformation WHERE ProfileID=5";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    information = new ContactInformation()
                    {
                        Address = reader.GetString(0),
                        Mobile = reader.GetString(1)
                    };

                }

                reader.Close();
                command.Dispose();
            }

            return information;
        }

        public List<ExperienceDetail> GetExperiences(int professionID)
        {
            List<ExperienceDetail> details = new List<ExperienceDetail>();

            if (connection != null)
            {
                string sql = string.Format(@"SELECT ExperienceID, CompanyName, YearFrom, MonthFrom FROM ProfessionExperiences WHERE ProfessionID={0} ORDER BY YearFrom DESC, MonthFrom DESC", professionID);

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ExperienceDetail detail = new ExperienceDetail()
                        {
                            ID = reader.GetInt32(0),
                            CompanyName = reader.GetString(1),
                            DateFrom = new DateTime(reader.GetInt32(2), reader.GetInt32(3), 1)
                        };

                        details.Add(detail);
                    }
                }

                reader.Close();
                command.Dispose();
            }

            return details;
        }

        public ExperienceDetail GetExpericenDetail(int experienceID)
        {
            ExperienceDetail detail = null;

            if (connection != null)
            {
                string sql = string.Format(@"SELECT ExperienceID, CompanyName, JobTitleLeft, YearFrom, MonthFrom, YearTo, MonthTo, Summary FROM ProfessionExperiences WHERE ExperienceID={0}", experienceID);

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    detail = new ExperienceDetail()
                    {
                        ID = reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        FinalJobTitle = reader.GetString(2),
                        DateFrom = new DateTime(reader.GetInt32(3), reader.GetInt32(4), 1),
                        DateTo = reader.GetInt32(5) == 0 ? DateTime.Now : new DateTime(reader.GetInt32(5), reader.GetInt32(6), 1),
                        Summary = reader.GetString(7)
                    };
                }

                reader.Close();
                command.Dispose();
            }

            return detail;
        }

        public List<EducationDetail> GetEducations(int profileID)
        {
            List<EducationDetail> details = new List<EducationDetail>();

            if (connection != null)
            {
                string sql = string.Format(@"SELECT EducationID, EducationTitle, Institution, Summary, YearTo FROM Educations WHERE ProfileID={0} ORDER BY YearTo", profileID);

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EducationDetail detail = new EducationDetail()
                        {
                            ID = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Institution = reader.GetString(2),
                            Summary = reader.GetString(3),
                            YearCompleted = reader.GetInt32(4)
                        };

                        details.Add(detail);
                    }
                }

                reader.Close();
                command.Dispose();
            }

            return details;
        }

        public Profession GetDefaultProfession(ProfileInformation profile)
        {
            if (profile == null)
            {
                throw new ArgumentNullException(nameof(profile));
            }

            Profession profession = null;

            if (connection != null)
            {
                string sql = string.Format(@"SELECT ProfessionID, JobTitle, Summary FROM Professions WHERE ProfileID={0} AND ProfessionID=5", profile.ID);

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    profession = new Profession()
                    {
                        ID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Summary = reader.GetString(2)
                    };

                    profile.Professions.Add(profession);
                }

                reader.Close();
                command.Dispose();
            }

            return profession;
        }

        public Dictionary<SkillCategory, List<Skill>> GetSkills(Profession profession)
        {
            if (profession == null)
            {
                throw new ArgumentNullException(nameof(profession));
            }

            if (connection != null)
            {
                string sql = string.Format(@"SELECT SkillID, SkillName, CategoryID, YearLastUsed, MonthLastUsed, Description FROM ProfessionSkills WHERE ProfessionID={0} ORDER BY CategoryID", profession.ID);

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    profession.Skills.Clear();

                    while (reader.Read())
                    {
                        Skill skill = new Skill()
                        {
                            ID = reader.GetInt32(0),
                            SkillName = reader.GetString(1),
                            Category = (SkillCategory)reader.GetInt32(2),
                            LastUsed = DateHelper.GetDateDisplay(reader.GetInt32(3), reader.GetInt32(4)),
                            Summary = reader.GetString(5)
                        };

                        List<Skill> skillsList = null;

                        if (!profession.Skills.TryGetValue(skill.Category, out skillsList))
                        {
                            skillsList = new List<Skill>();
                            profession.Skills[skill.Category] = skillsList;
                        }

                        skillsList.Add(skill);
                    }
                }

                reader.Close();
                command.Dispose();
            }

            return profession.Skills;
        }

        private SqlConnection CreateConnection()
        {
            string connectionString =
                @"Data Source=SQL5017.myWindowsHosting.com;Initial Catalog=DB_9D865D_alexyap1205info;User Id=DB_9D865D_alexyap1205info_admin;Password=x;Connection Timeout=60;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
