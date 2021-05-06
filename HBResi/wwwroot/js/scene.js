var scene;
var camera;
var cube;
var renderer;
var material;
var caller;
var container;

function createScene(reference) {

    container = document.getElementById('threejscontainer');
    if (!container) {
        return;
    }
   
    caller = reference;
    scene = new THREE.Scene();
    camera = new THREE.PerspectiveCamera(75, container.clientWidth / container.clientHeight, 0.1, 1000);
    renderer = new THREE.WebGLRenderer();
    renderer.setPixelRatio(window.devicePixelRatio);
    renderer.setSize(container.clientWidth, container.clientHeight);
   // document.body.appendChild(renderer.domElement);

   while (container.lastElementChild) {
       container.removeChild(container.lastElementChild);
    }

   container.appendChild(renderer.domElement);
    
}

function createCube() {
    var geometry = new THREE.BoxGeometry();
    material = new THREE.MeshBasicMaterial({ color: 0x00ff00 });
    cube = new THREE.Mesh(geometry, material);
    cube.callback = function () { caller.invokeMethodAsync('OnClickCube', cube); };
    scene.add(cube);
    camera.position.z = 5;
}

var animate = function () {
    requestAnimationFrame(animate);
    renderer.render(scene, camera);
};
