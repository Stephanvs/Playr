function PlayController($scope) {
    $scope.nowPlaying = {
        artist: 'Jason Mraz',
        songTitle: 'The Remedy',
        albumTitle: 'Waiting for My Rocket to Come',
        albumArtUrl: 'https://lh6.googleusercontent.com/-A_kpvHTz4x0/AAAAAAAAAAI/AAAAAAAAAKc/Z4gA-QiPlS8/s250-c-k/photo.jpg',
        backdropImageUrl: 'http://www.htbackdrops.com/v2/albums/userpics/12686/normal_jason_mraz1.jpg'
    };
}

function PlaylistController($scope) {
    

}

function BackdropController($scope) {
    $scope.updateBackdrop = function(backdropUrl) {
        // todo: update backdrop image
    };
}