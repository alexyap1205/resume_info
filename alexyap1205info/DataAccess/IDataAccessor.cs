using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccessor
    {
        void Initialize();

        void UnInitialize();

        ProfileInformation GetDefaultProfile();

        Profession GetDefaultProfession(ProfileInformation profile);

        Dictionary<SkillCategory, List<Skill>> GetSkills(Profession profession);

        ContactInformation GetContactInformation();

        List<ExperienceDetail> GetExperiences(int professionID);

        ExperienceDetail GetExpericenDetail(int experienceID);

        List<EducationDetail> GetEducations(int profileID);
    }
}
