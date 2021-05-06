


var scene;
var camera;
var cube;
var renderer;
var material;
var caller;
var container;
var controls;


function createScene(reference) {

    container = document.getElementById('threejscontainer');
    if (!container) {
        return;
    }

    caller = reference;
    scene = new THREE.Scene();
    scene.fog = new THREE.FogExp2(0xcccccc, 0.002);
    scene.background = new THREE.Color(0xa0a0a0);
    camera = new THREE.PerspectiveCamera(75, container.clientWidth / container.clientHeight, 0.1, 1000);
    camera.position.z = 5;
  

    renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setPixelRatio(window.devicePixelRatio);
    renderer.setSize(container.clientWidth, container.clientHeight);



    var gridHelper = new THREE.GridHelper(10, 20);
    scene.add(gridHelper);

    const dirLight1 = new THREE.DirectionalLight(0xffddcc, 1);
    dirLight1.position.set(1, 0.75, 0.5);
    scene.add(dirLight1);

    const dirLight2 = new THREE.DirectionalLight(0xccccff, 1);
    dirLight2.position.set(- 1, 0.75, - 0.5);
    scene.add(dirLight2);

    // container
    while (container.lastElementChild) {
        container.removeChild(container.lastElementChild);
    }

  
    container.appendChild(renderer.domElement);

}

function createCube() {

    const geometry = new THREE.TorusKnotGeometry();

     material = new THREE.MeshPhongMaterial({ color: 0xffffff, flatShading: true });

     cube = new THREE.Mesh(geometry, material);

    scene.add(cube);

    //controls = new OrbitControls(camera, renderer.domElement);
    //controls.screenSpacePanning = true;
    //controls.minDistance = 5;
    //controls.maxDistance = 40;
    //controls.target.set(0, 2, 0);
    //controls.update();
}

var animate = function () {
    requestAnimationFrame(animate);

    cube.rotation.x += 0.007;
    cube.rotation.y += 0.007;

    renderer.render(scene, camera);

};
