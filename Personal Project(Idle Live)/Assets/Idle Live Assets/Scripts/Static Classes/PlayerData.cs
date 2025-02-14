﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public static class PlayerData //Put here every variable that should be in SaveGame
{
    public static int newOrContinueGame = 0; //Use to understand which mode is chosen. New Game or Continue Game
    
    //Timer Data
    public static float days;
    public static float years;

    //Job Data    
    public static bool isJobActive;
    public static bool[] jobEnabledStatus = new bool[8]; //Activ or not particular job
    public static float[] jobExpCurrentValue = new float[8]; //Job current progress values
    public static float[] jobExpMaxValue = new float[8]; //Job max values
    public static bool[] jobLvlLoading = new bool[8]; //Used to show lvl of jobs first time, when loading the game
    public static int[] jobLvlValue = new int[8];
    public static int currentJobReqNumber; //According to this number the requiremets shows for next job
        //Income
        public static float currentBasicJobPayment; //Use to calculate income
        public static float[] jobPayMultiplier = new float[8]; //Use to save current income multiplier from lvl of job
        public static float currentJobPayMultiplier; //Use to calculate income
        //Other
        public static int currentJobSelectedNumber; //USed to save currently selected job

    //Skill Data
    public static float[] skillMultipliersArray = new float[5]; //Stores different multiplierls
    //multipliersArray[0] - Endurance affects exp progress of skills  //Endurance - Skill Experience //Discipline[1] - Job Experience //Motivation[2] - Job payment //Negotiations[3] - Ecology income //Management[4] - Ecology cost decrease

    //Reincarnation upgrade Data
    public static float jobIncMultR; //Stores the multipluer of job income from Reincarnation upgrade
    public static int jobIncMultLvlR;//Stores lvl of job income upgrade
    public static float jobExpMultR; //Stores the multipluer of job experience boost from Reincarnation upgrade
    public static int jobExpMultLvlR;//Stores lvl of job experience boost upgrade
    public static float skillExpMultR; //Stores the multipluer of skill experience boost from Reincarnation upgrade
    public static int skillExpMultLvlR;//Stores lvl of skill experience boost upgrade
    public static float techExpMultR; //Stores the multipluer of technology experience boost from Reincarnation upgrade
    public static int techExpMultLvlR;//Stores lvl of technology experience boost upgrade
    public static float techCostMultR; //Stores the multipluer of technology cost reduction from Reincarnation upgrade
    public static int techCostMultLvlR;//Stores lvl of technology cost reduction upgrade
}