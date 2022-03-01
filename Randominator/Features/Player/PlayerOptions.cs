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
            "aNLJ04DtgTA",  // fligu gigu 10h. Yeah, another one with higher chance
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
            "BCGIPf5bgmQ",  // dance monkey (leo's cover)
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
            "cZzK32Cfcq8",  // rasputin (putin version)
            "QiFBgtgUtfw",  // tri poloski
            "UcRtFYAz2Yo",  // dance till you're dead 10h
            "b8HO6hba9ZE",  // we like to party
            "G9Y5Dhzciyc",  // die woodys
            "kNH_EjHvm3I",  // keyboard cat 10h
            "WqmGFfNco0g",  // puddi puddi
            "sVYlkLauPlY",  // peanut butter jelly time 10h
            "YnopHCL1Jk8",  // dragostea din tei
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
            "Tx5nF3Gay0A",  // habibi arab cat
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
            "XaO_3GcQyiE",  // evil troll 1h
            "DrxdjxXXZug",  // burning memory but depressing 1h
        };
    }
}
