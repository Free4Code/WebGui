(function () {
    'use strict';

    var serviceId = 'datacontext';
    angular.module('app').factory(serviceId, ['common', datacontext]);

    function datacontext(common) {
        var $q = common.$q;

        var service = {
            getPeople: getPeople,
            getMessageCount: getMessageCount
        };

        return service;

        function getPeople() {
            var people = [
                { firstName: 'Carl', lastName: 'Loche', age: 40, location: 'Nantes' },
                { firstName: 'Flo', lastName: 'Rivereau', age: 31, location: 'Peta ouchnock' },
                { firstName: 'Yoyo', lastName: 'FlocLay', age: 31, location: 'Nantes' },
                { firstName: 'Clément', lastName: 'Longchamp', age: 18, location: 'Rennes' },
                { firstName: 'Fred', lastName: 'Flament', age: 41, location: 'Flament Ville' }
            ];
            return $q.when(people);
        }

        function getMessageCount() { return $q.when(72); }
    }
})();