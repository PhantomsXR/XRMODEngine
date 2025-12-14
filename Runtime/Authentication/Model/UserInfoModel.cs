// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the AuthenticationSystem.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/


namespace Phantom.XRMOD.GameServices.Runtime
{
    [System.Serializable]
    public class UserInfoModel
    {
        public string token;
        public string player_name; 
        public string email;
        public string user_avatar;
        public string mobile;
        public string accountId;

        public void CleanUp()
        {
             token = user_avatar = player_name = email = mobile = accountId = string.Empty;
        }
    }
}