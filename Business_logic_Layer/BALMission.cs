using Data_Access_Layer;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_Layer
{
    public class BALMission
    {
        private readonly DALMission _dalMission;

        public BALMission(DALMission dalMission)
        {
            _dalMission = dalMission;
        }

        public List<Missions> MissionList()
        {
            return _dalMission.MissionList();
        } 

        public string AddMission(Missions mission)
        {
            return _dalMission.AddMission(mission);
        }

        public async Task<List<MissionSkill>> GetMissionSkillListAsync()
        {
            return await _dalMission.GetMissionSkillListAsync();
        }
        public async Task<List<MissionTheme>> GetMissionThemeListAsync()
        {
            return await _dalMission.GetMissionThemeListAsync();
        }
        public List<Missions> ClientSideMissionList(int userId)
        {
            return _dalMission.ClientSideMissionList(userId);
        }


        public async Task<List<MissionApplication>> GetMissionApplicationListAsync()
        {
            return await _dalMission.GetMissionApplicationListAsync();
        }
    }
}
