namespace TehGM.Randominator.Features.Player
{
    // Randominator is open source so there's no way to fully hide this. Congratulations. You know all the tracks now. 

    public class PlayerOptions
    {
        public bool AllowVideosByID { get; set; } = false;

        public double PlayerAppearChance { get; set; } = 0.05;
        public bool EnableControls { get; set; } = false;
        public IEnumerable<string> VideoIDs { get; set; } = new string[]
        {
            "_S7WEVLbQ-Y",  // shreksophone 1h
            "_S7WEVLbQ-Y",  // shreksophone 1h. Yes double is intentional
            "_S7WEVLbQ-Y",  // shreksophone 1h. Yes triple is intentional as well
            "aNLJ04DtgTA",  // fligu gigu 10h
            "dQw4w9WgXcQ",  // never gonna give you up
            "V7HdWeYbV3Q",  // walking polar bear 10h
            "6iFbuIpe68k",  // epic sax guy 10h
            "lOfZLb33uCg",  // amish paradise
            "N9qYF9DZPdw",  // white & nerdy
            "hGlyFc79BUE",  // badgers 10h
            "xu4YQ0XZFVM",  // WBTBWB mansnothot
            "9S7viJ_Lfxc",  // slavic metal
            "Atm0GwWs6lw",  // Monolith propaganda
            "rEckY-TUv9I",  // cheeki breeki
            "qisDkf0bXFM",  // za monolith
            "F4J9-CQXdPk",  // taking hobbits to isengard 10h
            "wU0X_cfDHdo",  // why's the rum gone 10h
            "ZG_k5CSYKhg",  // epic faith no more
            "241aWydxJqA",  // telefonmast
            "XVON0vP8k4s",  // pos - tape wurms
            "SPKwBdFIuz4",  // r33mix fucknation
            "QlJVM5rUa7I",  // r33mix the fuck empire
            "ncUhQpiWTnM",  // lazypurple raining men (original)
            "X_X0xnrx-iY",  // lazypurple raining men (extended)
            "j6N4vQ6m360",  // I'm so fresh
            "ioudby-xooc",  // nice weather for ducks
            "C2AgqjvvYWY",  // r33mix peanut
            "G_zJa-W3ajQ",  // r33mix black
            "iEXPkv7lJgc",  // we are number one
            "vqMp1tXcF38",  // smahs mouth (Shrek vid)
            "j9V78UbdzWI",  // astronomia (coffin vid)
            "3rzgrP7VA_Q",  // what is love (car vid)
            "kD1-wIL28po",  // sweet dreams, wrongly toned version
            "ToJyWEBAdAY",  // what does the fax say
            "j8xoV-v1Yl0",  // little v - halogen - u got that
            "NvjcwY_CraA",  // elevator music 1h
            "yzC4hFK5P3g",  // ponponpon
            "68ugkg9RePc",  // i'm blue
            "Jr9DM3St0vA",  // take on me
            "rvYZRskNV3w",  // this is sparta techno remix
            "y6120QOlsfU",  // darude sandstorm
            "N9TAO80825M",  // zigu zigule
            "3OJfUOIGeaU",  // turn down for what
            "PGNiXGX2nLU",  // you spin me round
            "xat1GVnl8-k",  // bad touch
            "qTsaS1Tm-Ic",  // basshunter dota
            "_3ngiSxVCBs",  // c418 (minecraft)
            "W4VTq0sa9yg",  // san andreas
            "sCNrK-n68CM",  // trolololo 10h
            "Hy8kmNEo1i8",  // scatman
            "HQoRXhS7vlU",  // the x files
            "DKo9ok2829M",  // what is love (leo's cover)
            "NL86PuqH8y0",  // genie in a bottle (leo's cover)
            "3vnVzoEz_Zs",  // barbie girl (leo's cover)
            "i1H0leZhXcY",  // careless bork
            "uB2IVlsByrw",  // du hast (animal cover)
            "6MLeME9PieI",  // chop suey (animal cover)
            "q8q4beo51Hk",  // baby shark + psychosocial
            "1B6_4mHBCD8",  // psychosical + baby shark
            "w15oWDh02K4",  // gigi dagositno - lamour toujours
            "Hrph2EW9VjY",  // gigi dagositno - bla bla bla
            "cvvd-9azD1M",  // gigi dagositno - the riddle
            "3ijDdxmoiX0",  // super mario theme
            "9eawJyEuyQc",  // metal trump - down with the sickness
            "zCc3TVYJyO0",  // metal trump - breaking the law
            "-50NdPawLVY",  // crab rave
            "5ngWIDkPP3o",  // arabian cat
            "O-jOEAufDQ4",  // beer is good
            "QHRuTYtSbJQ",  // BFG division
            "udISHiLIUvk",  // chug jug with you (little v's cover)
            "zqLEO5tIuYs",  // nyan cat 12h
            "OQ2k2bL5gvU",  // erboh - darth vader vs hitler
            "AeNYDwbm9qw",  // erboh - napoleon vs napoleon
            "zn7-fVtT16k",  // erboh - einstein vs hawking
            "_lK4cX5xGiQ",  // tenacious d - tribute
            "hvvjiE4AdUI",  // tenacious d - kickapoo
            "80DtQD5BQ_A",  // tenacious d - master exploder
            "vOBKxUT9Da4",  // tenacious d - beelzeboss
            "5nl7sKwPQo4",  // pain - party in my head
            "Eii-UXpOvSs",  // plastic men
            "MtN1YnoL46Q",  // the duck song
            "rLy-AwdCOmI",  // i feel fantastic
            "C_h1dY66Rm4",  // suicide mouse
            "M75VLQuFPrY",  // don't look at the moon
            "o_cikTgwMXY",  // the best song
            "rRPQs_kM_nw",  // polish cow 10h
            "2jC8IYBC8Yo",  // zimne dranie (Phineas & Ferb)
            "4Dv0SQly5rE",  // nie czuje rytmu (Phineas & Ferb)
            "bVPd6hf-Nlw",  // perry the platypus (Phineas & Ferb)
            "5WzswZXTMZQ",  // simp (Phineas & Ferb)
            "PKoftlq_n2A",  // look at this photograph
            "SW-BU6keEUw",  // mom's spaghetti
            "otCpCn0l4Wo",  // can't touch this
            "eAnRryw-jFY",  // final countdown bongo cat
            "bSr9oxNKgoU",  // ameno dorime (with cats)
            "X0Gr7IFfoqI",  // imperial march trumpet
            "FLgYVOTKrO8",  // imperial march 10h
            "lp6z3s1Gig0",  // pink panther
            "o61BiBCXMCI",  // trump bad guy
            "oWqAf4eex14",  // jellyfish jam
            "mOYZaiDZ7BM",  // cotton eye joe
            "TKfS5zVfGBc",  // sound system dreamscape
            "B-N1yJyrQRY",  // leek spin 10h
            "irDRwzJ7ed8",  // tunak tun 10h
            "ygI-2F8ApUM",  // brodyquest
            "kfVsfOSbJY0",  // friday (rebecca black)
            "ytWz0qVvBZ0",  // diggy diggy hole
            "NnmwuiptvEU",  // kazoo 10h
            "JaPf-MRKITg",  // star wars cantina
            "ZZ5LpwO-An4",  // HEYYEYAAEYAAAEYAEYAA
            "xqTBlft8gQA",  // trio - da da da trio
            "5CEiwddPKyE",  // shrek electric zoo
            "iPrnduGtgmc",  // ding dong song
            "i0xOSxgs6w8",  // moskau
            "QiFBgtgUtfw",  // tri poloski
            "UcRtFYAz2Yo",  // dance till you're dead 10h
            "b8HO6hba9ZE",  // we like to party
            "G9Y5Dhzciyc",  // die woodys
            "kNH_EjHvm3I",  // keyboard cat 10h
            "WqmGFfNco0g",  // puddi puddi
            "sVYlkLauPlY",  // peanut butter jelly time 10h
            "k85mRPqvMbE",  // crazy frog
            "kGGoeDrjL5g",  // crazy frog (neo kids version)
            "MlW7T0SUH0E",  // chacarron
            "cokQJq9oTN8",  // freaks
            "d7FIpqPvL7E",  // barbie girl (soldiers version)
            "ykwqXuMPsoc",  // narwhals
            "AVbQo3IOC_A",  // fresh prince of bel air
            "fc43pgsSmT4",  // gummy bear 1h
            "VW3U_5igckI",  // last resort animal cover
            "5uPoDNEn3I0",  // america fuck yeah
            "p-WErNe1x18",  // let me hit it (LoL lux version)
            "yydNF8tuVmU",  // Harder, Better, Faster, Stronger
            "y90yaLFoYoA",  // adidas hardbass
            "JC2egrdAVYs",  // cheeki breeki (original)
            "LLZMk9cRK-U",  // raining men (r33mix version)
            "kJa2kwoZ2a4",  // it's my life whatever I wanna do
            "3hgcy6bsg4g",  // ulduar
            "Cv0tsRJzNvA",  // hed "hollow"
            "4nw0cD47jJs",  // klocuch - hot16
            "1ty3mFU8EtA",  // klocuch - kruci gang
            "M1BEfcXBNLI",  // klocuch - aezakmi
            "9bSxOhoM9pE",  // konglelujah
            "Q16KpquGsIc",  // ronald macdonald insanity
            "Xp7PaA_dQ_E",  // UN Owen dog of wisdom
            "cbB3iGRHtqA",  // scooter - how much is the fish
            "51bhB7EKHdQ",  // scooter - maria
            "xmDqILHP4is",  // copypasta as bad rap (anime)
            "dWNvlyycWzQ",  // oki doki boomer (anime)
            "8vVpybPnBpg",  // bitch wasagna owo (anime)
            "ufXz-m7viiY",  // your mama
            "_8mpnN2fVYQ",  // nyhm - just loot it
            "UM8TAMythsM",  // gigi - achievement wh0re
            "GoWKKmZoRgM",  // best haul video on internet
            "yCrJ2m-FOaQ",  // you live here (meatsleep)
            "R9OZK55oWT4",  // wolf (meatsleep)
            "IJGMbBdV-qg",  // r33mix a goddamn bear
            "XxhxGfowhPc",  // r33mix this is how the world works
            "tcOUeoiYwIg",  // r33mix fuckworld
            "CwtfXzMvNYI",  // r33mix fuckville
            "ecIHgR-GNLI",  // r33mix repent
            "aJ53CdbGW2A",  // r33mix clarity
            "TBsdWW7MOew",  // you need me (gmod)
            "Kikkrn7-vZM",  // r33mix "..."
            "fCxrkkFv1qw",  // r33mix rainbow
            "FJITHvAmS_Y",  // BPM level 5
            "LXIWRan3XGY",  // type o negative - I don't wanna be me
            "gi1CASWEkt4",  // drg leave no dwarf behind
            "WBuDIqpBB7A",  // the final catdown
            "NUYvbT6vTPs",  // Cat Vibing To Ievan Polkka
            "TUxYTdlcUMw",  // cat vibing to aaaaahhhh
            "3eRBFkxgG7g",  // dancing coolest kid
            "IBnKAxrYCkg",  // cat vibing to rasputin
            "5jKZ9KGtee0",  // squish that cat
            "CbozHK38jDc",  // cat dancing to lady hear me tonight 1h
            "nfKzYh73UZI",  // cat vibing to the rebel path (cp77)
            "QXkSYSPTpj4",  // hotline miami OST - crystals
            "84q83skr_tk",  // hotline miami OST - hydrogen
            "hmqcn8Vy9HU",  // gangsta's notes
            "y_110_vlVn0",  // despaciNOTE
            "bpszIdtcWQc",  // take on those notes
            "7q87foWAkFU",  // boulevard of broken notes
            "HqBp6LA_I_s",  // all stars (notes version)
            "CWicMlSSpZk",  // metaltrump - psychosocial
            "sJ7rvAL1oMI",  // metaltrump - not falling
            "NFi4pfWXAVs",  // metaltrump - blind
            "CufwRGsVLhU",  // metaltrump - du hast
            "ltM5jHIJFw4",  // jace hall - i play wow
            "VLnWf1sQkjY",  // jizz in my pants
            "4-UbHw8eDzM",  // happy monkey circle 10h
            "VKS-aW4TlOM",  // And The Unrighteous Were Turned To Ash
            "dvoVZ765qBE",  // bonzo + kobra - dupa cycki i wagina
            "JY-HNLLSJp0",  // bonzo + kobra - billie jean
            "tujpti71jtM",  // kobra - titanic
            "_OuMq7U9sl8",  // kobra - last xmas
            "l7qKD-Ph7ds",  // 300 latino comedy
            "gEpNPV-dCIQ",  // fidlar - awkward
            "SAUpOohn8iw",  // fidlar - leave me alone
            "XJE8GZupffI",  // yellow submarine + eh marine
            "tOsck7jYUsE",  // goofy - wake me up inside
            "70WBJdwijik",  // klocuch - jak zapomnieć, chinese version
            "Oor8D5_dTcI",  // klocuch - ojciec mateusz 1h
            "CIiuzTna-zQ",  // Sakharovs Anthem
            "UYKLGX9-_4Y",  // stalker campfire song pixel animation
            "VEj762Govhs",  // ozzy, are you sober now?
            "I6uzKSuz-p4",  // shrek krumps 10h
            "Tx5nF3Gay0A",  // habibi arabian cat
            "8dVQ0813KVM",  // beeping cat
            "Z3oyT9BiGC4",  // shrek baby dancing to ~~minecraft music~~ snoop dogg
            "o1gRV9zjAYQ",  // shrek and waldo twerk
            "rwykU-8TP5c",  // shrexy
            "WPywfWMPgt4",  // shrek swalla
            "xNoSi7acNgc",  // shrek it off
            "s9yOAglXni4",  // shrek chika dance
            "Ptva46pehus",  // shrek morning flower
            "w0DhZtzhaus",  // shrek cat
            "oCij5Kx5av0",  // raising shrek
            "9nz55mGQEd0",  // shrek single ladies
            "jdE3ZAcTgDw",  // end this mans whole career
            "GPXkjtpGCFI",  // sike that's the wrong number
            "mseMvvgp86c",  // shrek don't stop me now
            "ymNFyxvIdaM",  // freestyler
            "Yavx9yxTrsw",  // boxxy
            "i8ju_10NkGY",  // you are a pirate
            "uD4izuDMUQA",  // timelapse of the future
            "YLXanZICdK0",  // madness combat (all in real time)
            "wuFrq5e5WMU",  // madness combat experiment
            "UBLIAasOfxk",  // the sculpture (SCP-173)
            "D_h2G6QMMjA",  // poradnik uśmiechu 1
            "v0g5QbWTkLo",  // poradnik uśmiechu 2
            "EFH9soeufXY",  // winnie the pooh dancing to pitbull
            "Fa1MqYrd6U4",  // nas ne dogonyat
            "bJG4EFSl2Fs",  // randsophone
            "EWjAmpmADBg",  // Doofenshmirtz Quality Bratwurst 10h
            "sJxTQ-Ejfus",  // Amazing Horse Jazz
            "iUcqT5zpZ5E",  // how animals eat their food
            "DMawWBwHnBU",  // duck spinning 10h
            "g5tSl4t1-xU",  // duck spinning geometry dash but it’s vaporwave
            "L2Zt8TIcrUU",  // obamium spinning to geometry dash practice mode
            "1DxRko3ER4Q",  // 10 sec songs - numb in style of killswitch engage
            "dFSQ6gvra1c",  // 10 sec songs - psychosocial in style of linkin park
            "iC1PLC6ljJc",  // space doggo 10h (ps1 trainers/cracks music)
            "3SCBYUE_X1U",  // he 10h (walking cat)
            "yT16_7Jizn8",  // PÚA PÚA PÚA PÚA PÚA PI PI PI PI PI PI
            "Kg-HHXuOBlw",  // seels
            "cjJOWJ4_q5A",  // Go Kitty Go Speed Up 10h
            "oQY_xAmywxk",  // flamingo 10h
            "Fqi3uMvSat0",  // tunez
            "p0rXznBDfJM",  // monkey driving golf cart, GTASA music, 10h
            "isYt-BWrQfk",  // apple cat running 1h
            "oe6b5tMMw1k",  // cat with headphones 10h
            "bhsgn1v79as",  // phonk trollge 1h
            "XaO_3GcQyiE",  // plague doctor dance
            "DrxdjxXXZug",  // burning memory but depressing 1h
            "rmHDhAohJlQ",  // the prodigy - breathe
            "a4eav7dFvc8",  // the prodigy - out of space
            "lsV500W4BHU",  // powerman 5000 - when worlds collide
            "yi-KQ3CKOQU",  // doggos dancin 1h
            "NATSpYWERIE",  // nokia espionage 10h
            "sXxbkjlHvf4",  // oreo
            "o8hYrNsRoTs",  // karen metal
            "rCSkWIdTONA",  // karen metal 2
            "tnLLrnZVwFI",  // karen metal 4
            "E5nsRs1e_q0",  // our table it's broken
            "c7BVtGnlxT8",  // why do I hear boss music original
            "V58fBGcbaCs",  // meet my son hecker jr
            "jYO503VGd6k",  // 5 inches deep in your mum
            "ebw6G6sIeHw",  // tf2 slap my...
            "CS9OO0S5w2k",  // YMCA
            "BQ4c54rCJ_k",  // reebok or nike
            "kYV4heJ5Y7k",  // hello my name is mary
            "67j3nQdsoSw",  // my name is giovanni giorgio (spider human)
            "hl6ibkLDvLk",  // my name is giovanni giorgio (reaper)
            "9iOpVqXz7dk",  // gary sings twist
            "m_6gfvXja9M",  // gary sings *naughty rap, whatever it's called*
            "KhvqED3Ud48",  // gary sings nigga nigga
            "lFbPi8o0OEU",  // gary + spongebob + squidward - meow
            "07kcMqltz3Q",  // gary - xmas songs
            "BZoUuZue81o",  // gary poetry
            "NlcWBPDl5WA",  // duck dancing to hey ya
            "0QDKLglEP5Y",  // men without hands - safety dance
            "Y414Q7vVgYU",  // safety dance, adam jensen version
            "kEPfM3jSoBw",  // titanic with a cat
            "1mf06IwdpVM",  // lotr with a cat
            "W85oD8FEF78",  // jurassic park with a cat
            "nf7GsKFepDg",  // godzilla vs cat
            "2kppIwA9Bsg",  // home alone with a cat
            "Nhuf-wS1CbI",  // witcher with a cat
            "MIkxDXyNgAU",  // shining with a cat
            "ra2MPDpdKnU",  // friends with a cat
            "F2QAOS6llpw",  // friends intro poland
            "EShUeudtaFg",  // am I pregnant questions
            "X3XVlnFoYDQ",  // some mother that I used to do (gotye parody)
            "aTfaRC0XfB4",  // oh no I mist
            "0jzFjmIbX8c",  // games are bad they make you mad (postal 2)
            "u5w1Q5wFkHQ",  // dad interrupts ball tricks
            "SChnJDfmrSU",  // portal radio 10h
            "Y6ljFaKRTrI",  // portal still alive
            "Rsips1I0vew",  // spooky scary skeletons in 1 voice
            "EqpfI_LcU50",  // asmr sounds of stepdad
            "sPg0rpIN53Q",  // jettan coke
            "PIc8NVyUrrw",  // jettan russherica 1
            "nIGZSXUD1GM",  // everything you touch turns into skittles
            "hBmpMMkXz6Y",  // ankha dance but cat shark
            "oc4dGO9AuBA",  // dw is sus
            "46MALEk-7cE",  // megadeth - duke nukem
            "LzdO_itzYSU",  // duke nukem roasts franklin
            "l6nQAKMxRXU",  // duke nukem bedtime story
            "l6nQAKMxRXU",  // duke nukem unexpected quotes
            "m1TnzCiUSI0",  // The Italian Man Who went to Malta
            "-XccUMOQ978",  // Schfifty Five
            "0ogJtX-Z7Xs",  // songs in real life
            "9bZkp7q19f0",  // gangnam style
            "wWLhrHVySgA",  // chinese food
            "M3iOROuTuMA",  // salad fingers 1
            "cuCw5k-Lph0",  // salad fingers 2
            "ojoICRzSCOo",  // salad fingers 3
            "M5V_IXMewl4",  // stick bug
            "989-7xsRLR4",  // vitas 7th element
            "v1K4EAXe2oo",  // eeeaaaooo (cat)
            "AjdVZyO5q18",  // green orxnge (trollge) 1h
            "SNxYodddgvc",  // he was a good stalker (doomerwave) (stalker)
            "tFbVZCbLhOk",  // campfire song with distortions (doomerwave) -- russian title (stalker)
            "SeHYcxohxCk",  // Xue hua piao piao bei feng xiao xiao (shrek)
            "f9XiD_2K7-Q",  // paradise lost - small town boy
            "WtO3AHMBePY",  // triangle pumped up kicks
            "-DVmNrX8dZU",  // birb is laugh then destroy
            "MFmr_TZLpS0",  // banana dance
            "142d500n_9g",  // whoever threw that paper your moms a hoe
            "ZYepB5ppEWM",  // dirge for the planet but surrounded by Monolith
            "XtAhISkoJZc",  // chop suey but everything is a table
            "puI9sy9vjyI",  // psycho vladolf putler crazy
            "tmY-G6sngk8",  // rickroll spanish inquisition
            "pifBpLAun6U",  // my name is chicky
            "myhMnljOC10",  // boohbah skipping rope
            "jhExvE5fvJw",  // eminem - crab god
            "QfOLwSyq0Wg",  // arab cat original song
            "xMSGnGL8JU0",  // gopnik dance cheeki breeki style
            "bVoouSAhytw",  // rating countries by slavness
            "8sNekrl9x9g",  // will smith slaps the rock
            "C8nsz6TK5bI",  // will smith doesn't slap chris rock
            "H7S7CwkttV0",  // friends ross has no friends
            "Uu1JONP5fD4",  // bandit dance
            "gAYL5H46QnQ",  // threw it on the ground
            "vmd1qMN5Yo0",  // the shooting aka dear sister
            "5WTkJHHF4B4",  // horror movie daycare
            "uukvEcd25oQ",  // std song
            "tz1aZq3axgg",  // hakke en zage
            "U0Og4LaB1Zc",  // wrecking ball nicolas cage
            "G_miGclPFGs",  // one pound fish (music video)
            "fpGIZstcXzU",  // one pound fish (original)
            "3YvGFsc0SYw",  // I sit - cat (sugar soad)
            "Q8i2WPxXxS4",  // wilfred warrior
            "w0AOGeqOnFY",  // the coconut song
            "U9t-slLl30E",  // bad lip reading - seagulls
            "LACbVhgtx9I",  // muffin song
            "8zIpaDa0UQw",  // oblivion NPC cat
            "wAu_fYHZKLs",  // time traveller (sfm)
            "jvRX5ixyiaQ",  // meth song
            "Tq55upxAlyA",  // queen pretends she's a normal person
            "wdWuQP6862U",  // the jizzle
            "oxzEdm29JLw",  // tutel
            "1AIVA1bmxFw",  // krawczyk - parostatkiem (+ coolio, dre, snoop dogg, ice cube)
            "lXj2Oj1H0mM",  // will smith goes metal
            "DoqPEhVHdBM",  // bad grandpa pageant
            "soh1U9tdrs0",  // medieval real slim shady
            "Hl5dRW4E9hc",  // pizza song
            "A3ytTKZf344",  // reggae shark
            "cjUPVKEN9tI",  // super hexagon - hexagonest
            "Libic29tjbs",  // heavy's pizza song
            "6jJkdRaa04g",  // yello - oh yeah
            "q6EoRBvdVPQ",  // yee
            "ujQBKpjYqfE",  // serbia strong
            "sVjk5nrb_lI",  // spooky scary skeletons
            "ZyhrYis509A",  // aqua - barbie girl
            "dv13gl0a-FA",  // initial d - deja vu
            "LBjUh4bYF8w",  // hamsterdance 2
            "FzG4uDgje3M",  // dame tu cosita
            "3oIbztWsY8g",  // ludacris - move bitch
            "6-8E4Nirh9s",  // caramelldansen
            "YVkUvmDQ3HY",  // eminem - without me
            "KmtzQCSh6xk",  // numa numa (dud singing dragostea din tei)
            "IiDQwQQsrL8",  // bouldevard of broken dreams in paint
            "fbGkxcY7YFU",  // what what in the butt
            "EwTZ2xpQwpA",  // chocolate rain
            "feA64wXhbjo",  // bag raiders - shooting stars
            "hMtZfW2z9dw",  // bed intruder song (hide yo kids)
            "Ppm5_AGtbTo",  // chicken yodeling
            "YkuSmJtRY8E",  // nugget in a biscuit 10h
            "fWNaR-rxAic",  // carly rae jepsen - call me maybe
            "hLljd8pfiFg",  // the globglogabgalab
            "Kppx4bzfAaE",  // rappin for jesus
            "8vJiSSAMNWw",  // harlem shake
            "6vYnas6q3Sg",  // ot genasis - coco
            "Mz3Mi_OZYno",  // all the single furries
            "dlFA0Zq1k2A",  // kana-boon - silhouette
            "g-sgw9bPV4A",  // kazoo kid trap remix
            "vfc42Pb5RA8",  // pokemon go song
            "dgha9S39Y6M",  // mine diamonds
            "Ct6BUPvE2sM",  // ppap (apple pen)
            "iB3fZGTm6a8",  // cbid (cyka blyat ppap parody)
            "yx2piPUudlE",  // yung gravy - mr clean
            "rzc3_b_KnHc",  // dat stick
            "OLpeX4RRo28",  // ping guy - stfu
            "CMA2iF6RuXk",  // fergie US anthem
            "ls3rD8VfiSY",  // tenacious d - rize of the fenix
            "N0hFf-twPlY",  // tenacious d - you never give me your money
            "cwhctFi0Em8",  // if soad made take on me
            "MrN8K2nDcUM",  // my name is giovanni giorgo child
            "_x14hNEf_tI",  // it's prom
            "_IJdRRBEsUs",  // discord cats - hecker gets mad
            "ixYKcytJKbo",  // discord cats - kars rickrolls hecker
            "0J_a9Uae1Jk",  // discord cats - beluga gets rickrolled
            "zbIzyhomrUI",  // discord cats - if beluga owned a discord server
            "dGrMJHsWe0U",  // discord cats - hecker fixes beluga's computer
            "i-M3K4miJMw",  // discord cats - pablo as discord server owner
            "xjip93wTvJo",  // discord cats - hecker meets scemer
            "0ZJ5dSlVFNI",  // discord cats - hecker vs evil musk
            "LxQv3ajw9nY",  // discord cats - hecker hacks FBI
            "RVPmEXEmKWs",  // discord cats - hecker deletes beluga
            "69Hitt9Dw4Y",  // discord cats - hecker finds beluga's password
            "OhvCJGRBX1A",  // discord cats - pablo vs flat earther
            "TovdjYooStg",  // discord cats - beluga gets unmodded
        };
    }
}
