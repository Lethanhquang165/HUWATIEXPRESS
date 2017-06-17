﻿define(['app'], function (app) {
    app.controller("HomeCtrl", function ($scope, tinhThanhPhoService) {
          debugger;
        $scope.TinhThanhPhos = [];
        $scope.gheDaChons = [];
        $scope.tinhThanhId = "";

        $scope.loadTinhThanh = function () {
            tinhThanhPhoService.getTinhThanhList()
                .success(function (data) {
                    $scope.TinhThanhPhos = data;
                })
                .error(function () {
                })
        };

        $scope.toggle = function () {
          
            var a = this.tinh;
            a.Chon = !a.Chon;

            if (a.Chon && !a.Register) {
                var index = $scope.gheDaChons.indexOf(a.Id);
                if (index === -1) {
                    $scope.gheDaChons.push(a.Id);
                }
            }
            else {
                var index = $scope.gheDaChons.indexOf(a.Id);
                if (index !== -1) {
                    $scope.gheDaChons.splice($scope.gheDaChons.indexOf(a.Id), 1);
                }
            }
        }

        //$scope.$watch("tinhThanhId", function () {
        //    alert($scope.tinhThanhId);
        //});
        $scope.loadTinhThanh();
    });
});