function PlayController($scope, $http) {

    $scope.updateCurrentTrack = function() {
        $http.get('home/GetQueue').success(function(data) {
            $scope.CurrentTrack = data.CurrentTrack;
        });
    };
    $scope.updateCurrentTrack();

    var hub = $.connection.playr;

    hub.DjInfoUpdated = $scope.updateCurrentTrack;

    $.connection.hub.url = "http://localhost:5554/signalr";
    $.connection.hub.start();
}

function PlaylistController($scope) {


}

function BackdropController($scope) {
    $scope.updateBackdrop = function (backdropUrl) {
        // todo: update backdrop image
    };
}