import React from 'react'
import { useEffect, useState } from 'react'
import "../assets/css/contributor.css"

function Contributor() {
    //var data = JSON.parse(localStorage.getItem('user'));
    //data.createdOn = new Date(data.createdOn).toLocaleDateString();
    //var [user, setUser] = useState(data);

    //const { GetUserRating, GetUserRank, GetUserAwards } = DashboardService(); // Servisi çağır
    //var rating = 0;
    //var rank = "";
    //var awards = [];
    //useEffect(() => {
    //    const fetchUserStats = async () => {
    //        rating = await GetUserRating(user.id);
    //        setUser(prev => ({ ...prev, rating: rating }));
    //        rank = await GetUserRank(user.id)
    //        setUser(prev => ({ ...prev, rank: rank }));
    //        awards = await GetUserAwards(user.id)
    //        setUser(prev => ({ ...prev, awards: awards }));
    //    };

    //    fetchUserStats(); // Sayfa yüklendiğinde çağır
    //}, []);

    //console.log(user);

    return <div className="y-contributor-container">
        <div className="y-contributor-menu-box"><span className="y-contributor-menu-text">Katkı Puanım : 117.8</span></div>
        <div className="y-contributor-menu-box"><span className="y-contributor-menu-text">Sorularım</span></div>
        <div className="y-contributor-menu-box"><span className="y-contributor-menu-text"> Kalite Değerlendirmelerim</span> </div>
        <div className="y-contributor-menu-box"><span className="y-contributor-menu-text"> Zorluk Değerlendirmelerim</span> </div>

    </div>
}

export default Contributor