using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Person : MonoBehaviour {

	public enum SpriteEnum{
		SWEET_ASIAN = 0,
		SWEET_BLACK = 1,
		SWEET_HISPANIC = 2,
		SWEET_WHITE = 3,
		DANDY_ASIAN = 4,
		DANDY_BLACK = 5,
		DANDY_HISPANIC = 6,
		DANDY_WHITE = 7,
		PRINCESS_ASIAN = 8,
		PRINCESS_BLACK = 9,
		PRINCESS_HISPANIC = 10,
		PRINCESS_WHITE = 11,
		DEFAULT_KID_ASIAN = 12,
		DEFAULT_KID_BLACK = 13,
		DEFAULT_KID_HISPANIC = 14,
		DEFAULT_KID_WHITE = 15,
		DEFAULT_WOMAN_ASIAN = 16,
		DEFAULT_WOMAN_BLACK = 17,
		DEFAULT_WOMAN_HISPANIC = 18,
		DEFAULT_WOMAN_WHITE = 19,
		POLICE_ASIAN = 20,
		POLICE_BLACK = 21,
		POLICE_HISPANIC = 22,
		POLICE_WHITE = 23,
		DAD_ASIAN = 24,
		DAD_BLACK = 25,
		DAD_HISPANIC = 26,
		DAD_WHITE = 27,
		DEFAULT_MALE_ASIAN = 28,
		DEFAULT_MALE_BLACK = 29,
		DEFAULT_MALE_HISPANIC = 30,
		DEFAULT_MALE_WHITE = 31,
		JOCK_ASIAN = 32,
		JOCK_BLACK = 33,
		JOCK_HISPANIC = 34,
		JOCK_WHITE = 35,
		SPORTS_ASIAN = 36,
		SPORTS_BLACK = 37,
		SPORTS_HISPANIC = 38,
		SPORTS_WHITE = 39,
		UGG_ASIAN = 40,
		UGG_BLACK = 41,
		UGG_HISPANIC = 42,
		UGG_WHITE = 43,
		CAT_ASIAN = 44,
		CAT_BLACK = 45,
		CAT_HISPANIC = 46,
		CAT_WHITE = 47,
		BAKER_ASIAN = 48,
		BAKER_BLACK = 49,
		BAKER_HISPANIC = 50,
		BAKER_WHITE = 51,
		WALKER_ASIAN = 52,
		WALKER_BLACK = 53,
		WALKER_HISPANIC = 54,
		WALKER_WHITE = 55,
		PIGTAILS_ASIAN = 56,
		PIGTAILS_BLACK = 57,
		PIGTAILS_HISPANIC = 58,
		PIGTAILS_WHITE = 59,
		SPORTSGIRL_ASIAN = 60,
		SPORTSGIRL_BLACK = 61,
		SPORTSGIRL_HISPANIC = 62,
		SPORTSGIRL_WHITE = 63,
		CHUBBY_ASIAN = 64,
		CHUBBY_BLACK = 65,
		CHUBBY_HISPANIC = 66,
		CHUBBY_WHITE = 67,
		MOM_ASIAN = 68,
		MOM_BLACK = 69,
		MOM_HISPANIC = 70,
		MOM_WHITE = 71,
		GOATEE_ASIAN = 72,
		GOATEE_BLACK = 73,
		GOATEE_HISPANIC = 74,
		GOATEE_WHITE = 75
	}

	public enum Personality{
		Jock,
		Sweet,
		Dandy,
		Dad,
		Police,
		Princess,
		Sports,
		Ugg,
		Cat,
		Baker,
		Walker,
		Pigtails,
		Sportsgirl,
		Chubby,
		Mom,
		Goatee,
		Default
	};

	public SpriteEnum spriteName;

	public Personality personality;
	Demographic dems;
	public Disease disease;

	// Use this for initialization
	void Start () {
		
	}

	public void AddDem(Demographic dem){
		dems = dem;
	}

	public void AddDisease(Disease d){
		disease = d;
	}

	public void ChoosePersonality(){
		personality = Personality.Default;

		//list of probabilities for each personality type
		List<float> probsPerPersonality = new List<float>();

		if (dems.sex == Demographic.Sex.Female && dems.age == Demographic.Age.Old) {
			float roll = Random.Range (0.0f, 1.0f);
			if(roll <= 0.33f){
				personality = Personality.Sweet;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.SWEET_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.SWEET_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.SWEET_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.SWEET_WHITE;
					break;
				}
			}
			else if(roll <=0.66f){
				personality = Personality.Baker;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.BAKER_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.BAKER_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.BAKER_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.BAKER_WHITE;
					break;
				}
			}
			else {
				personality = Personality.Cat;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.CAT_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.CAT_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.CAT_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.CAT_WHITE;
					break;
				}
			}
		}

		if (dems.sex == Demographic.Sex.Female && dems.age == Demographic.Age.Middle) {
			float roll = Random.Range(0.0f, 1.0f);
			if(roll <= 0.25f){
				personality = Personality.Default;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.DEFAULT_WOMAN_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.DEFAULT_WOMAN_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.DEFAULT_WOMAN_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.DEFAULT_WOMAN_WHITE;
					break;
				}
			}
			else if(roll <=0.5f){
				personality = Personality.Police;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.POLICE_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.POLICE_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.POLICE_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.POLICE_WHITE;
					break;
				}
			}
			else if(roll <=0.75f){
				personality = Personality.Mom;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.MOM_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.MOM_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.MOM_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.MOM_WHITE;
					break;
				}
			}
			else {
				personality = Personality.Ugg;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.UGG_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.UGG_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.UGG_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.UGG_WHITE;
					break;
				}
			}
		}

		if (dems.sex == Demographic.Sex.Female && dems.age == Demographic.Age.Young) {
			float roll = Random.Range (0.0f, 1.0f);
			if(roll <= 0.33f){
				personality = Personality.Princess;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.PRINCESS_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.PRINCESS_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.PRINCESS_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.PRINCESS_WHITE;
					break;
				}
			}
			else if(roll <=0.66f){
				personality = Personality.Pigtails;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.PIGTAILS_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.PIGTAILS_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.PIGTAILS_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.PIGTAILS_WHITE;
					break;
				}
			}
			else {
				personality = Personality.Sportsgirl;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.SPORTSGIRL_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.SPORTSGIRL_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.SPORTSGIRL_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.SPORTSGIRL_WHITE;
					break;
				}
			}
		}

		if (dems.sex == Demographic.Sex.Male && dems.age == Demographic.Age.Old) {
			float roll = Random.Range (0.0f, 1.0f);
			if(roll <= 0.5f){
				personality = Personality.Dandy;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.DANDY_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.DANDY_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.DANDY_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.DANDY_WHITE;
					break;
				}
			}
			else {
				personality = Personality.Walker;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.WALKER_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.WALKER_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.WALKER_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.WALKER_WHITE;
					break;
				}
			}
		}

		if (dems.sex == Demographic.Sex.Male && dems.age == Demographic.Age.Middle) {
			float roll = Random.Range(0.0f, 1.0f);
			if(roll <= 0.25f){
				personality = Personality.Default;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.DEFAULT_MALE_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.DEFAULT_MALE_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.DEFAULT_MALE_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.DEFAULT_MALE_WHITE;
					break;
				}
			}
			else if (roll <= 0.5f){
				personality = Personality.Jock;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.JOCK_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.JOCK_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.JOCK_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.JOCK_WHITE;
					break;
				}
			}
			else if (roll <= 0.75f){
				personality = Personality.Goatee;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.GOATEE_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.GOATEE_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.GOATEE_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.GOATEE_WHITE;
					break;
				}
			}
			else {
				personality = Personality.Dad;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.DAD_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.DAD_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.DAD_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.DAD_WHITE;
					break;
				}
			}
		}

		if (dems.sex == Demographic.Sex.Male && dems.age == Demographic.Age.Young) {
			float roll = Random.Range(0.0f, 1.0f);
			if(roll <= 0.33f){
				personality = Personality.Default;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.DEFAULT_KID_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.DEFAULT_KID_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.DEFAULT_KID_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.DEFAULT_KID_WHITE;
					break;
				}
			}
			else if (roll <= 0.66f){
				personality = Personality.Chubby;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.CHUBBY_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.CHUBBY_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.CHUBBY_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.CHUBBY_WHITE;
					break;
				}
			}
			else {
				personality = Personality.Sports;
				switch(dems.race)
				{
				case Demographic.Race.Asian:
					spriteName = SpriteEnum.SPORTS_ASIAN;
					break;
				case Demographic.Race.Black:
					spriteName = SpriteEnum.SPORTS_BLACK;
					break;
				case Demographic.Race.Hispanic:
					spriteName = SpriteEnum.SPORTS_HISPANIC;
					break;
				case Demographic.Race.White:
					spriteName = SpriteEnum.SPORTS_WHITE;
					break;
				}
			}
		}


		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
